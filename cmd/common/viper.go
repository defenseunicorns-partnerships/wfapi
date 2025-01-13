package common

import (
	"fmt"
	"github.com/defenseunicorns-partnerships/wfapi/pkg/environment"
	"net"
	"net/url"
	"os"
	"regexp"
	"strings"
)

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

	VEnvironment        = "environment"
	VEnvironmentLong    = "environment"
	VEnvironmentShort   = "e"
	VEnvironmentDefault = "Production"
	VEnvironmentUsage   = `Env: WFAPI_ENVIRONMENT
CfgFile: environment
Environment to use for logging and other purposes`

	// Serve config keys

	VServePort        = "serve.port"
	VServePortLong    = "port"
	VServePortShort   = "p"
	VServePortDefault = 8080
	VServePortUsage   = `Env: WFAPI_SERVE_PORT
CfgFile: serve.port
Port to serve the API on`

	VServeBucketRegion      = "serve.bucket.region"
	VServeBucketRegionLong  = "bucket-region"
	VServeBucketRegionShort = "r"
	VServeBucketRegionUsage = `Env: WFAPI_SERVE_BUCKET_REGION
CfgFile: serve.bucket.region
Region of the S3-compatible bucket to use`

	VServeBucketServiceUrl      = "serve.bucket.service-url"
	VServeBucketServiceUrlLong  = "bucket-service-url"
	VServeBucketServiceUrlShort = "u"
	VServeBucketServiceUrlUsage = `Env: WFAPI_SERVE_BUCKET_SERVICE_URL
CfgFile: serve.bucket.service-url
URL of the S3-compatible object storage service`

	VServiceBucketName      = "serve.bucket.name"
	VServiceBucketNameLong  = "bucket-name"
	VServiceBucketNameShort = "b"
	VServiceBucketNameUsage = `Env: WFAPI_SERVE_BUCKET_NAME
CfgFile: serve.bucket.name
Name of the S3-compatible bucket to use`
)

func ValidateEnvironment(input string) error {
	_, err := environment.ParseEnum(input)
	if err != nil {
		return fmt.Errorf("invalid environment value: %w", err)
	}
	return nil
}

func ValidateConfig(configPath string) error {
	// Check if the file exists
	if _, err := os.Stat(configPath); os.IsNotExist(err) {
		return fmt.Errorf("config file does not exist: %s", configPath)
	}

	return nil
}

func ValidateServePort(port int) error {
	if port < 1 || port > 65535 {
		return fmt.Errorf("port must be between 1 and 65535, got %d", port)
	}

	return nil
}

func ValidateServeBucketRegion(region string) error {
	// Minimum of 3 characters, maximum of 63
	if len(region) < 3 || len(region) > 63 {
		return fmt.Errorf("region must be between 3 and 63 characters, got %d", len(region))
	}

	// Can consist only of lowercase letters, numbers, and hyphens (-)
	if !regexp.MustCompile("^[a-z0-9-]+$").MatchString(region) {
		return fmt.Errorf("region must consist only of lowercase letters, numbers, and hyphens, got %s", region)
	}

	// Must begin and end with a letter or number
	if !regexp.MustCompile("^[a-z0-9].*[a-z0-9]$").MatchString(region) {
		return fmt.Errorf("region must begin and end with a letter or number, got %s", region)
	}

	// Must not contain two adjacent hyphens
	if regexp.MustCompile("--").MatchString(region) {
		return fmt.Errorf("region must not contain two adjacent hyphens, got %s", region)
	}

	return nil
}

func ValidateServeBucketServiceUrl(inputUrl string) error {
	// Parse the input string as a URL
	parsedUrl, err := url.Parse(inputUrl)
	if err != nil {
		return fmt.Errorf("invalid URL format: %w", err)
	}

	// Check that the scheme is either HTTP or HTTPS
	if parsedUrl.Scheme != "http" && parsedUrl.Scheme != "https" {
		return fmt.Errorf("URL must have http or https scheme")
	}

	// Ensure the host is not empty
	if parsedUrl.Host == "" {
		return fmt.Errorf("URL must have a valid host")
	}

	// If all checks pass, return nil
	return nil
}

func ValidateServeBucketName(bucketName string) error {
	// Source: https://docs.aws.amazon.com/AmazonS3/latest/userguide/bucketnamingrules.html

	// Check length
	if len(bucketName) < 3 || len(bucketName) > 63 {
		return fmt.Errorf("bucket name must be between 3 and 63 characters long")
	}

	// Check allowed characters
	matched, err := regexp.MatchString(`^[a-z0-9.-]+$`, bucketName)
	if err != nil {
		return fmt.Errorf("error validating bucket name characters: %w", err)
	}
	if !matched {
		return fmt.Errorf("bucket name can only contain lowercase letters, numbers, dots (.), and hyphens (-)")
	}

	// Check start and end characters
	if !regexp.MustCompile(`^[a-z0-9]`).MatchString(bucketName) || !regexp.MustCompile(`[a-z0-9]$`).MatchString(bucketName) {
		return fmt.Errorf("bucket name must begin and end with a letter or number")
	}

	// Check for adjacent periods
	if strings.Contains(bucketName, "..") {
		return fmt.Errorf("bucket name must not contain two adjacent periods")
	}

	// Check if formatted as an IP address
	if net.ParseIP(bucketName) != nil {
		return fmt.Errorf("bucket name must not be formatted as an IP address")
	}

	// Check restricted prefixes
	restrictedPrefixes := []string{"xn--", "sthree-", "sthree-configurator", "amzn-s3-demo-"}
	for _, prefix := range restrictedPrefixes {
		if strings.HasPrefix(bucketName, prefix) {
			return fmt.Errorf("bucket name must not start with the prefix %s", prefix)
		}
	}

	// Check restricted suffixes
	restrictedSuffixes := []string{"-s3alias", "--ol-s3", ".mrap", "--x-s3"}
	for _, suffix := range restrictedSuffixes {
		if strings.HasSuffix(bucketName, suffix) {
			return fmt.Errorf("bucket name must not end with the suffix %s", suffix)
		}
	}

	// All checks passed
	return nil
}
