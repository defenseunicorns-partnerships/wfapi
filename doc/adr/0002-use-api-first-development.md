# 2. Use API-First Development

Date: 2024-11-05

## Status

Accepted

## Context

WFAPI is a REST API service originally written in C# / ASP.NET Core, where it followed a Code-First development approach. The Code-First methodology was chosen initially due to the ease of use provided by the ASP.NET Core ecosystem, specifically with Swashbuckle. Swashbuckle came pre-installed and mostly configured in the ASP.NET Core project template, offering seamless OpenAPI v3 support and automatic documentation generation from code annotations. However, with our decision to rewrite WFAPI in Golang, we encountered some challenges with maintaining a Code-First approach:

- Lack of Mature Code-First Support: Golang lacks a clearly favored Code-First library. While some open-source libraries exist, many do not support OpenAPI v3, which limits our ability to generate up-to-date API specifications directly from code.
- Intentional API Design: We want to make the API specification the primary source of truth for our application, treating it as a contract that guides development. This approach helps ensure consistency, promotes design-first thinking, and facilitates smoother collaboration across teams.
- Tooling Availability: Our decision was made easier with the discovery of Apicurio, a UI-based editor that supports OpenAPI v3. Apicurio enables us to collaboratively define and maintain an OpenAPI spec, making it easier to manage the API’s structure and documentation from the outset.

For these reasons, we decided to adopt an API-First approach for the new Golang-based version of WFAPI.

## Decision

We will follow an API-First development process for WFAPI. The OpenAPI specification will serve as the definitive source of truth for the API, and development efforts will align with this spec. We will use Apicurio to create and manage the openapi-spec.yaml file, which will drive both API implementation and documentation.

## Consequences

**Positive Consequences**

- Clear Contract for Development: Treating the API spec as the source of truth promotes a contract-first approach, making it easier for different teams (e.g., frontend, QA, backend) to collaborate effectively.
- Enhanced API Consistency: An API-First approach forces us to be more intentional about API design choices, resulting in a more consistent and well-documented API.
- Tooling Benefits: Apicurio provides a user-friendly interface for managing the OpenAPI spec, reducing the manual overhead and ensuring that the spec is always up-to-date and accurate.

**Negative Consequences**

- Initial Learning Curve: Adopting API-First requires a shift in mindset for our developers, who are accustomed to a Code-First approach with automatic documentation generation.
- Increased Upfront Effort: Designing the API spec upfront requires more initial effort, as we need to carefully define endpoints, data models, and expected behaviors before writing the code.

**Risks**

- Specification Drift: If the implementation diverges from the spec, it could lead to inconsistencies between the documented contract and actual functionality. To mitigate this, we will enforce spec compliance checks in our CI/CD pipeline.

This decision ensures that our API design aligns with modern best practices, improves cross-team collaboration, and makes WFAPI more maintainable as it evolves.