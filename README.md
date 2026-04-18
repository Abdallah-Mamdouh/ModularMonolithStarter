🚀 e-Shop Modular Monolith (.NET 8)

This repository implements a production-oriented backend system built with .NET 8 and ASP.NET Core Minimal APIs, designed to demonstrate modern backend architecture patterns and scalable system design principles.

The focus of this project is architecture, modularity, and real-world backend design, rather than feature completeness.

It showcases how to design and implement a maintainable, extensible system using modern architectural patterns:

Modular Monolith Architecture (Modulith)
Vertical Slice Architecture (VSA)
Domain-Driven Design (DDD)
CQRS (Command Query Responsibility Segregation)
Outbox Pattern for reliable messaging
Event-driven communication with RabbitMQ & MassTransit
Secure APIs using Keycloak (OAuth2 / OpenID Connect / JWT Bearer)
Cross-cutting concerns (logging, validation, caching, error handling)

🏗 Architecture Overview

Core Principles
Pattern	Description
Modular Monolith	Single deployable unit with strict module boundaries
Vertical Slice Architecture	Feature-based organization instead of layered architecture
Domain-Driven Design (DDD)	Business-driven domain modeling
CQRS	Separation of read/write models for scalability
Outbox Pattern	Reliable event publishing with transactional consistency

🔄 Module Communication

Synchronous Communication: In-process calls via module APIs
Asynchronous Communication: Event-driven messaging using RabbitMQ & MassTransit

🔐 Security

Keycloak as Identity Provider
OAuth2 / OpenID Connect
JWT Bearer Token authentication

🧩 Project Modules

🛒 Catalog Module

Minimal APIs with .NET 8
Vertical Slice Architecture (Feature-based structure)
CQRS with MediatR
Domain & Integration Events (e.g. Price Updates)
EF Core + PostgreSQL (Code-First)
Validation, Logging, Exception Handling, Pagination

🧺 Basket Module

DDD + CQRS + Vertical Slices
Redis Distributed Cache with PostgreSQL fallback
Cache-aside, Proxy, and Decorator patterns
Publishes BasketCheckoutEvent via RabbitMQ
Outbox Pattern for reliable messaging

🔐 Identity Module

Keycloak integration for authentication & authorization
OAuth2 / OpenID Connect flows
Docker-based Keycloak setup
JWT-secured APIs across modules

📦 Ordering Module

Handles checkout workflow (Basket → Order)
DDD + CQRS + Vertical Slice Architecture
Outbox Pattern for reliable event handling
Event-driven integration with other modules

⚙️ Cross-Cutting Concerns

Logging: Serilog
Validation: MediatR Pipeline Behaviors
Exception Handling
Caching: Redis
Pagination support

🛠 Tech Stack

.NET 8 / C# 12
ASP.NET Core Minimal APIs
Entity Framework Core + PostgreSQL
MediatR (CQRS & Domain Events)
Redis (Caching)
RabbitMQ + MassTransit (Event-driven architecture)
Keycloak (Identity & Access Management)
Docker / Docker Compose

📦 Design Patterns Applied

Proxy Pattern
Decorator Pattern
Cache-aside Pattern
CQRS
Vertical Slice Architecture
Domain & Integration Events
Outbox Pattern

🔮 Future Enhancements

Migration toward Microservices using Strangler Fig Pattern
Payments Module
Shipping Module
Notification System
Observability (Logging / Metrics / Tracing improvements)

📚 References

Vertical Slice Architecture
Domain-Driven Design (DDD)
CQRS & MediatR
Outbox Pattern
Keycloak Documentation
