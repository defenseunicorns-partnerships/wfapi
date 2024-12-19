package cmd

import (
	"fmt"
	"github.com/spf13/cobra"
)

func NewServeCommand() *cobra.Command {
	serveCmd := &cobra.Command{
		Use:           "serve",
		Short:         "Start the WFAPI server",
		Args:          cobra.NoArgs,
		SilenceUsage:  true,
		SilenceErrors: false,
		Run: func(cmd *cobra.Command, _ []string) {
			fmt.Printf("Hello!")
		},
	}

	return serveCmd
}
