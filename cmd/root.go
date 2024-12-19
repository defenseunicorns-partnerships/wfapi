package cmd

import (
	"fmt"
	"os"

	"github.com/spf13/cobra"
	"github.com/spf13/viper"
)

var cfgFile string

var rootCmd = NewRootCommand()

func NewRootCommand() *cobra.Command {
	rootCmd := &cobra.Command{
		Use:   "wfapi COMMAND",
		Short: "REST API for interacting with Argo Workflows",
		Long: `WFAPI is a REST API for interacting with Argo Workflows. You'll want to use this if:

- You manage a Kubernetes cluster that runs mission apps that need the ability to initiate and monitor workflow jobs.
- You run Argo Workflows to provide that functionality.
- But for security reasons you don't want to give those mission apps direct access to the Kubernetes API.
- And you want more fine-grained control than what the Argo Workflows Server API would provide.`,
		Args:              cobra.MaximumNArgs(1),
		SilenceUsage:      true,
		SilenceErrors:     false,
		PersistentPreRunE: preRun,
	}

	rootCmd.AddCommand(NewServeCommand())

	return rootCmd
}

// Execute adds all child commands to the root command and sets flags appropriately.
// This is called by main.main(). It only needs to happen once to the rootCmd.
func Execute() {
	err := rootCmd.Execute()
	if err != nil {
		os.Exit(1)
	}
}

func init() {
	cobra.OnInitialize(initConfig)

	// Here you will define your flags and configuration settings.
	// Cobra supports persistent flags, which, if defined here,
	// will be global for your application.

	rootCmd.PersistentFlags().StringVarP(&cfgFile, "config", "c", "", "Optional config file | Default: $HOME/.wfapi.yaml | Env: WFAPI_CONFIG")
	err := viper.BindPFlag("config", rootCmd.PersistentFlags().Lookup("config"))
	if err != nil {
		fmt.Fprintln(os.Stderr, "Error binding flag to viper:", err)
		os.Exit(1)
	}
}

// initConfig reads in config file and ENV variables if set.
func initConfig() {
	viper.SetEnvPrefix("wfapi")
	viper.AutomaticEnv()

	cfgEnv := viper.GetString("config")
	if cfgFile != "" {
		viper.SetConfigFile(cfgFile)
	} else if cfgEnv != "" {
		viper.SetConfigFile(cfgEnv)
	} else {
		// Find home directory.
		home, err := os.UserHomeDir()
		cobra.CheckErr(err)

		// Search config in home directory with name ".wfapi" (without extension).
		viper.AddConfigPath(home)
		viper.SetConfigType("yaml")
		viper.SetConfigName(".wfapi")
	}

	// If a config file is found, read it in.
	err := viper.ReadInConfig()
	if err == nil {
		fmt.Fprintln(os.Stderr, "Using config file:", viper.ConfigFileUsed())
	} else if cfgFile == "" && cfgEnv == "" {
		fmt.Fprintln(os.Stderr, "Not using a config file")
	} else {
		fmt.Fprintln(os.Stderr, "Error reading config file:", err)
		fmt.Fprintln(os.Stderr, "Use --help flag for more information")
		os.Exit(1)
	}
}

func preRun(cmd *cobra.Command, _ []string) error {
	return nil
}
