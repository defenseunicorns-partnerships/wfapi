#TODO: Change to cgr.dev/$ORGANIZATION/go-fips:latest. Will require chainguard login.
FROM cgr.dev/chainguard/go:latest AS builder

COPY . /app
ENV CGO_ENABLED=0
RUN --mount=type=cache,target=/root/go/pkg/mod cd /app && go build -o wfapi .

#TODO: Change to cgr.dev/$ORGANIZATION/glibc-openssl-fips:latest. Will require chainguard login.
FROM cgr.dev/chainguard/static:latest
#FROM mcr.microsoft.com/devcontainers/go:dev-1.23
COPY --from=builder /app/wfapi /wfapi

EXPOSE 8080

CMD ["/wfapi", "serve", "-p", "8080"]
