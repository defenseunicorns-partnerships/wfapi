package common

const (
	// Root config keys

	VConfig        = "config"
	VConfigLong    = "config"
	VConfigShort   = "c"
	VConfigDefault = ""
	VConfigUsage   = `Env: WFAPI_CONFIG
Optional config file (default $HOME/.wfapi.yaml)`

	VLogLevel        = "log-level"
	VLogLevelLong    = "log-level"
	VLogLevelShort   = "l"
	VLogLevelDefault = "info"
	VLogLevelUsage   = `Env: WFAPI_LOG_LEVEL
CfgFile: log-level
Log level [debug, info, warn, error]`

	VLogFormat        = "log-format"
	VLogFormatLong    = "log-format"
	VLogFormatDefault = "console"
	VLogFormatUsage   = `Env: WFAPI_LOG_FORMAT
CfgFile: log-format
Log format [console, json, dev, none]`

	VNoColor        = "no-color"
	VNoColorLong    = "no-color"
	VNoColorDefault = false
	VNoColorUsage   = `Env: WFAPI_NO_COLOR
CfgFile: no-color
Disable colorized output`

	// Serve config keys

	VServePort        = "serve.port"
	VServePortLong    = "port"
	VServePortShort   = "p"
	VServePortDefault = 8080
	VServePortUsage   = `Env: WFAPI_SERVE_PORT
CfgFile: serve.port
Port to serve the API on`
)
