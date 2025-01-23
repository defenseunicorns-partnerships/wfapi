package server

import (
	"context"
	"github.com/aws/aws-sdk-go-v2/aws"
	"github.com/aws/aws-sdk-go-v2/config"
	"github.com/aws/aws-sdk-go-v2/service/s3"
	"github.com/defenseunicorns-partnerships/wfapi/api"
	"github.com/defenseunicorns-partnerships/wfapi/cmd/common"
	"github.com/defenseunicorns-partnerships/wfapi/pkg/environment"
	"github.com/defenseunicorns-partnerships/wfapi/pkg/logger"
	"github.com/go-chi/chi/v5"
	middleware "github.com/oapi-codegen/nethttp-middleware"
	"net"
	"net/http"
	"strconv"
)

func StartServer(port int, bucketRegion string, bucketServiceUrl string, bucketName string, env environment.Enum, wellKnownConfigUrl string) error {
	// Validate the port
	if err := common.ValidateServePort(port); err != nil {
		logger.Default().Error("Error validating port", "port", port, "error", err)
		return err
	}

	// Validate the bucket region
	if err := common.ValidateServeBucketRegion(bucketRegion); err != nil {
		logger.Default().Error("Error validating bucket region", "region", bucketRegion, "error", err)
		return err
	}

	// Validate the bucket service URL
	if err := common.ValidateServeBucketServiceUrl(bucketServiceUrl); err != nil {
		logger.Default().Error("Error validating bucket service URL", "url", bucketServiceUrl, "error", err)
		return err
	}

	// Validate the bucket name
	if err := common.ValidateServeBucketName(bucketName); err != nil {
		logger.Default().Error("Error validating bucket name", "name", bucketName, "error", err)
		return err
	}

	// Validate the wellKnownConfigUrl
	if err := common.ValidateWellKnownConfigUrl(wellKnownConfigUrl); err != nil {
		logger.Default().Error("Error validating wellKnownConfigUrl", "url", wellKnownConfigUrl, "error", err)
		return err
	}

	swagger, err := api.GetSwagger()
	if err != nil {
		logger.Default().Error("Error getting swagger spec", "error", err)
		return err
	}

	// Clear out the servers array in the swagger spec, that skips validating
	// that server names match. We don't know how this thing will be run.
	swagger.Servers = nil

	// Establish an AWS S3 client
	// Load default AWS configuration
	cfg, err := config.LoadDefaultConfig(context.TODO(),
		config.WithRegion(bucketRegion),
	)
	if err != nil {
		logger.Default().Error("unable to load AWS SDK config", "error", err)
		return err
	}

	// Create S3 client
	logger.Default().Debug("Creating S3 Client", "region", bucketRegion, "bucketServiceUrl", bucketServiceUrl)
	s3Client := s3.NewFromConfig(cfg, func(o *s3.Options) {
		o.BaseEndpoint = aws.String(bucketServiceUrl)
		o.UsePathStyle = true
	})

	// Create an instance of our handler which satisfies the generated interface
	server := api.NewServer(s3Client, bucketName, env, wellKnownConfigUrl)

	// This is how you set up a basic chi router
	r := chi.NewRouter()

	// Use our validation middleware to check all requests against the
	// OpenAPI schema.
	r.Use(middleware.OapiRequestValidator(swagger))

	// We now register our server above as the handler for the interface
	api.HandlerFromMux(server, r)

	s := &http.Server{
		Handler: r,
		Addr:    net.JoinHostPort("0.0.0.0", strconv.Itoa(port)),
	}

	// And we serve HTTP until the world ends.
	logger.Default().Info("Starting WFAPI server", "port", port)
	err = s.ListenAndServe()
	if err != nil {
		logger.Default().Error("Server failed to start or stopped unexpectedly", "error", err)
		return err
	} else {
		logger.Default().Info("Server stopped")
		return nil
	}
}
