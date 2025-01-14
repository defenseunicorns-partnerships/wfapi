package cmd

import (
	"github.com/defenseunicorns-partnerships/wfapi/cmd/common"
	"github.com/defenseunicorns-partnerships/wfapi/pkg/environment"
	"github.com/defenseunicorns-partnerships/wfapi/pkg/logger"
	"github.com/defenseunicorns-partnerships/wfapi/pkg/server"
	"github.com/spf13/cobra"
	"github.com/spf13/viper"
	"os"
)

func NewServeCommand() *cobra.Command {
	cmd := &cobra.Command{
		Use:           "serve",
		Short:         "Start the WFAPI server",
		Args:          cobra.NoArgs,
		SilenceUsage:  false,
		SilenceErrors: false,
		RunE: func(cmd *cobra.Command, _ []string) error {
			// Get and validate the port
			port := viper.GetInt(common.VServePort)
			if err := common.ValidateServePort(port); err != nil {
				logger.Default().Error("Error validating port", "port", port, "error", err)
				return err
			}

			// Get and validate the region
			bucketRegion := viper.GetString(common.VServeBucketRegion)
			if err := common.ValidateServeBucketRegion(bucketRegion); err != nil {
				logger.Default().Error("Error validating bucket region", "region", bucketRegion, "error", err)
				return err
			}

			// Get and validate the service URL
			bucketServiceUrl := viper.GetString(common.VServeBucketServiceUrl)
			if err := common.ValidateServeBucketServiceUrl(bucketServiceUrl); err != nil {
				logger.Default().Error("Error validating bucket service URL", "url", bucketServiceUrl, "error", err)
				return err
			}

			// Get and validate the bucket name
			bucketName := viper.GetString(common.VServeBucketName)
			if err := common.ValidateServeBucketName(bucketName); err != nil {
				logger.Default().Error("Error validating bucket name", "name", bucketName, "error", err)
				return err
			}

			// Get and validate the environment
			environmentString := viper.GetString(common.VEnvironment)
			if err := common.ValidateEnvironment(environmentString); err != nil {
				logger.Default().Error("Error validating environment", "environment", environmentString, "error", err)
				return err
			}
			// Convert the environment string to environment.Enum
			envEnum, err := environment.ParseEnum(environmentString)
			if err != nil {
				logger.Default().Error("Error parsing environment to Enum", "environment", environmentString, "error", err)
				return err
			}

			// Get and validate the wellKnownConfigUrl
			wellKnownConfigUrl := viper.GetString(common.VServeWellKnownConfigUrl)
			if err := common.ValidateWellKnownConfigUrl(wellKnownConfigUrl); err != nil {
				logger.Default().Error("Error validating wellKnownConfigUrl", "url", wellKnownConfigUrl, "error", err)
				return err
			}

			err = server.StartServer(port, bucketRegion, bucketServiceUrl, bucketName, envEnum, wellKnownConfigUrl)
			if err != nil {
				logger.Default().Error("Server failed to start or stopped unexpectedly", "error", err)
				return err
			}
			return nil
		},
	}

	cmd.Flags().IntP(common.VServePortLong, common.VServePortShort, common.VServePortDefault, common.VServePortUsage)
	err := viper.BindPFlag(common.VServePort, cmd.Flags().Lookup(common.VServePortLong))
	if err != nil {
		logger.Default().Error("Error binding flag to viper:", err)
		os.Exit(1)
	}

	cmd.Flags().StringP(common.VServeBucketRegionLong, common.VServeBucketRegionShort, "", common.VServeBucketRegionUsage)
	err = cmd.MarkFlagRequired(common.VServeBucketRegionLong)
	if err != nil {
		logger.Default().Error("Error marking flag as required:", err)
		os.Exit(1)
	}
	err = viper.BindPFlag(common.VServeBucketRegion, cmd.Flags().Lookup(common.VServeBucketRegionLong))
	if err != nil {
		logger.Default().Error("Error binding flag to viper:", err)
		os.Exit(1)
	}

	cmd.Flags().StringP(common.VServeBucketServiceUrlLong, common.VServeBucketServiceUrlShort, "", common.VServeBucketServiceUrlUsage)
	err = cmd.MarkFlagRequired(common.VServeBucketServiceUrlLong)
	if err != nil {
		logger.Default().Error("Error marking flag as required:", err)
		os.Exit(1)
	}
	err = viper.BindPFlag(common.VServeBucketServiceUrl, cmd.Flags().Lookup(common.VServeBucketServiceUrlLong))
	if err != nil {
		logger.Default().Error("Error binding flag to viper:", err)
		os.Exit(1)
	}

	cmd.Flags().StringP(common.VServeBucketNameLong, common.VServeBucketNameShort, "", common.VServeBucketNameUsage)
	err = cmd.MarkFlagRequired(common.VServeBucketNameLong)
	if err != nil {
		logger.Default().Error("Error marking flag as required:", err)
		os.Exit(1)
	}
	err = viper.BindPFlag(common.VServeBucketName, cmd.Flags().Lookup(common.VServeBucketNameLong))
	if err != nil {
		logger.Default().Error("Error binding flag to viper:", err)
		os.Exit(1)
	}

	cmd.Flags().StringP(common.VServeWellKnownConfigUrlLong, common.VServeWellKnownConfigUrlShort, "", common.VServeWellKnownConfigUrlUsage)
	err = cmd.MarkFlagRequired(common.VServeWellKnownConfigUrlLong)
	if err != nil {
		logger.Default().Error("Error marking flag as required:", err)
		os.Exit(1)
	}
	err = viper.BindPFlag(common.VServeWellKnownConfigUrl, cmd.Flags().Lookup(common.VServeWellKnownConfigUrlLong))
	if err != nil {
		logger.Default().Error("Error binding flag to viper:", err)
		os.Exit(1)
	}

	return cmd
}
