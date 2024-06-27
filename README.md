# WF API

REST API for interacting with Argo Workflows

## Purpose

This project is a REST API for interacting with Argo Workflows. You'll want to use this if:

- You manage a Kubernetes cluster that runs mission apps that need the ability to initiate and monitor workflow jobs
- You run Argo Workflows to provide that functionality
- But you don't want to give those mission apps direct access to the Kubernetes API
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

## Installation

TODO: Write this section. Talk about how to deploy the Zarf package.

## Usage

TODO: Write this section. Talk about the self-documenting Swagger UI.

## FAQ

### What are the main features of this project?

- Trigger a workflow run from an existing template. Just provide the template name and any parameters.
- Get the status of one or more workflow runs.
- TBD

### Will I be able to create arbitrary workflows with this API?

Likely not. The plan for now is to only allow workflow runs that utilize an existing Workflow Template.

### What languages and frameworks are used in this project?

C# .NET Core Web API

### Why did you choose .NET Core Web API?

- Many of our mission app devs are most familiar with C# and .NET Core
- The team has quite a bit of experience with .NET Core as well
- There is a lot of existing code that we can reuse
- It is stable, performant, and well-supported
- We get JWT auth and self-documenting Swagger UI for "free"

### Will you ever support other workflow orchestrators?

Maybe. If you have a use case for this, please let us know.

### Who maintains this thing?

Defense Unicorns -> Delivery -> Navy Domain -> Task Force Narwhal -> DUDES

### I want to use this for some other project. Can I?

Yes, but your use case may not be supported by the maintainers. If this catches on and other teams want to use it, we'll look into transferring ownership to Product or some other more appropriate department.
