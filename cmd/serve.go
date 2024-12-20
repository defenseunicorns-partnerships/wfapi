package cmd

import (
	"fmt"
	"github.com/defenseunicorns-partnerships/wfapi/cmd/common"
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
		SilenceUsage:  true,
		SilenceErrors: true,
		RunE: func(cmd *cobra.Command, _ []string) error {
			err := server.StartServer()
			if err != nil {
				logger.Default().Error("Server failed to start or stopped unexpectedly", "error", err)
				return err
			}
			return nil
		},
		PreRunE: func(cmd *cobra.Command, args []string) error {
			var err error
			if port := viper.GetInt(common.VServePort); port < 1 || port > 65535 {
				err = fmt.Errorf("port must be between 1 and 65535, got %d", port)
				logger.Default().Error(err.Error())
			}
			return err
		},
	}

	cmd.Flags().IntP(common.VServePortLong, common.VServePortShort, common.VServePortDefault, common.VServePortUsage)
	err := viper.BindPFlag(common.VServePort, cmd.Flags().Lookup(common.VServePortLong))
	if err != nil {
		logger.Default().Error("Error binding flag to viper:", err)
		os.Exit(1)
	}

	return cmd
}
