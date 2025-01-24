# WFAPI

REST API for interacting with Argo Workflows

## Purpose

This project is a REST API for interacting with Argo Workflows. You'll want to use this if:

- You manage a Kubernetes cluster that runs mission apps that need the ability to initiate and monitor workflow jobs
- You run Argo Workflows to provide that functionality
- But for security reasons you don't want to give those mission apps direct access to the Kubernetes API
- And you want more fine-grained control than what the Argo Workflows Server API would provide

### Why not use the Argo Workflows Server API? Why build this instead?

- The Argo Server API utilizes Kubernetes Access Tokens for authentication.
- For each mission app, you'd have to set up a Role, ServiceAccount, and RoleBinding in your cluster.
- Kubernetes RBAC is error-prone and difficult to manage.
- RBAC in our clusters is managed centrally by SSO (Keycloak).
- Allows us to extend the API with custom functionality that the Argo Server API doesn't provide.
- Mission app developers only need a small subset of the functionality that Argo Server API would provide. This API is simpler and easier to use.

### But Argo Workflows Server API supports OIDC! Why not use that?

- We didn't catch that it supports SSO initially, but after looking at it, we still prefer this approach.
- We have already explored how to integrate with UDS Core's Keycloak/Authservice from a REST API and are confident that there aren't any unknown gotchas.
- If we handle auth using this API we can keep Argo Workflows Server API in "dumb mode" and not have to deal with integrating it with Keycloak/Authservice.
- If we want to expose the workflow orchestration functionality to other clusters or the internet, we can do so without exposing Argo Server, which would be a much larger thing to have to STIG/vet/approve.

![C4 Container Diagram](docs/diagrams/c4_container-0.png)

## Prerequisites

- Linux or MacOS x86_64
- Container runtime (we test using Docker, but others like Podman should work too)
- [K3d](https://k3d.io/)
- [UDS CLI](https://github.com/defenseunicorns/uds-cli)
- [yq](https://github.com/mikefarah/yq)

Windows is not supported at this time. We recommend using WSL2. Please let us know if you run into any issues when using WSL2.

## Installation

WFAPI is published as a [Docker image](https://github.com/defenseunicorns-partnerships/wfapi/pkgs/container/wfapi%2Fcontainers%2Fwfapi) as well as a [Zarf Package](https://github.com/defenseunicorns-partnerships/wfapi/pkgs/container/wfapi%2Fpackages%2Fwfapi) published as an OCI artifact. We recommend using the Zarf Package. See the [Zarf Docs](https://docs.zarf.dev/getting-started/) for details on how to deploy a Zarf Package. Use [Zarf config variables](https://docs.zarf.dev/ref/config-files/) for configuration. See [zarf.yaml](zarf/zarf.yaml) for all available configuration options.

## Usage

See [dotnet/README.md](dotnet/README.md).

## FAQ

### What are the main features of this project?

- Trigger a workflow run from an existing template. Just provide the template name and any parameters.
- Get the status of one or more workflow runs.
- TBD

### Will I be able to create arbitrary workflows with this API?

Likely not. The plan for now is to only allow workflow runs that utilize an existing Workflow Template.

### What languages and frameworks are used in this project?

C# .NET Core Web API. We are working on migrating to Golang. The .NET codebase is in the `dotnet` folder. The Golang codebase is in the `golang` folder. When the Golang codebase reaches feature parity with the .NET codebase the .NET codebase will be deleted.

### Will you ever support other workflow orchestrators?

Maybe. If you have a use case for this, please let us know.

### Who maintains this thing?

Defense Unicorns -> Delivery -> Navy Domain -> Task Force Narwhal -> DUDES

### I want to use this for some other project. Can I?

Yes, with a caveat that your use-case may not be a priority for the maintainers since their focus is on solving specific customer-based goals rather than building a general-use product. But feel free to submit issues or PRs and/or fork and modify as needed.
