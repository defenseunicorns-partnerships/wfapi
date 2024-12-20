package server

import (
	"fmt"
	"github.com/defenseunicorns-partnerships/wfapi/api"
	"github.com/defenseunicorns-partnerships/wfapi/cmd/common"
	"github.com/defenseunicorns-partnerships/wfapi/pkg/logger"
	"github.com/go-chi/chi/v5"
	middleware "github.com/oapi-codegen/nethttp-middleware"
	"github.com/spf13/viper"
	"net"
	"net/http"
	"strconv"
)

func StartServer() error {
	// Get the port and validate it
	port := viper.GetInt(common.VServePort)
	if port < 1 || port > 65535 {
		logger.Default().Error("Port must be between 1 and 65535", "port", port)
		return fmt.Errorf("port must be between 1 and 65535, got %d", port)
	}

	swagger, err := api.GetSwagger()
	if err != nil {
		logger.Default().Error("Error getting swagger spec", "error", err)
		return err
	}

	// Clear out the servers array in the swagger spec, that skips validating
	// that server names match. We don't know how this thing will be run.
	swagger.Servers = nil

	// Create an instance of our handler which satisfies the generated interface
	server := api.NewServer()

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
