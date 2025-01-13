package environment

import "fmt"

type Enum int

const (
	Development Enum = iota
	Test
	Production
)

func (e Enum) ToString() string {
	switch e {
	case Development:
		return "Development"
	case Test:
		return "Test"
	case Production:
		return "Production"
	default:
		return "Unknown"
	}
}

// ParseEnum converts a string to the Enum type or returns an error if the input string is invalid.
func ParseEnum(input string) (Enum, error) {
	switch input {
	case Development.ToString():
		return Development, nil
	case Test.ToString():
		return Test, nil
	case Production.ToString():
		return Production, nil
	default:
		return 0, fmt.Errorf("invalid enum value: %s", input)
	}
}
