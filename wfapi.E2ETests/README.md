# WFAPI E2E Tests

## Usage

```shell
dotnet test wfapi.E2ETests
```

## Known Issues

- The tests won't work on MacOS because UDS Core requires TLSv1.3+ which is not supported by .NET Core's HttpClient on MacOS. See [dotnet/runtime#1979](https://github.com/dotnet/runtime/issues/1979)
