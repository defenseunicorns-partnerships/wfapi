# 2. Programming language and framework

Date: 2024-07-29

## Status

Accepted

## Context

We are developing a new API and have to choose a programming language and framework. Our primary consideration is the ease of use for our initial customers, both of whom are C# shops and have requested this capability. While our company as a whole has more proficiency in Golang, the team developing this API has more experience with C# and Python, especially in creating REST APIs. Additionally, we have a significant amount of reusable code from a previous project that used C# / .NET Core Web API, which includes established solutions for JWT authentication and Swagger documentation. This previous project also requires C# due to its need to consume NuGet modules in order to serve another business-critical tool. Lastly, C# / .NET Core Web API is a stable, performant, and well-supported framework.

## Decision

We will use C# / .NET Core Web API for the development of our new API. This decision aligns with our customers' preferences and leverages our team's experience and existing reusable code. Despite the broader company proficiency in Golang, the specific skills and reusable assets available make C# the more practical choice for this project. This will also allow us to easily publish NuGet modules, enhancing usability for our customers.

## Consequences

The resulting context includes several key consequences:
- Positive: Our initial customers will find it easier to interact with the API, submit issues, and contribute to the codebase.
- Positive: The team can reuse existing code from another C# / .NET Core Web API project, saving development time and effort, especially for complex features like JWT authentication and Swagger documentation.
- Positive: C# / .NET Core Web API provides a stable, performant, and well-supported framework, reducing the risks associated with "unknown unknowns."
- Neutral: The team will leverage their collective experience with C# to develop the API efficiently.
- Negative: The broader company proficiency with Golang will not be utilized, potentially missing an opportunity to standardize on a single language across projects.
