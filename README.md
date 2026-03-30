# e-Shop Modular Monolith

[![.NET](https://img.shields.io/badge/.NET-8-blue)](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)

## 🚀 Overview

This repository contains the **EShop Modular Monolith (Modulith) application**, built using **.NET 8, and ASP.NET Core Minimal APIs**, following modern software architecture patterns.

The project demonstrates how to build **robust, scalable, and maintainable backend applications** using:

* **Modular Monolith (Modulith) Architecture**
* **Vertical Slice Architecture (VSA)**
* **Domain-Driven Design (DDD)**
* **Command Query Responsibility Segregation (CQRS)**
* **Outbox Pattern for Reliable Messaging**
* Event-driven communication with **RabbitMQ & MassTransit**
* Secure APIs using **Keycloak** with OpenID Connect and Bearer Tokens

The project also covers **cross-cutting concerns** like logging, validation, caching, and design patterns such as Proxy, Decorator, and Cache-aside.

## 🏗 Architecture Overview

### Core Concepts

| Pattern / Architecture          | Description                                                                            |
| ------------------------------- | -------------------------------------------------------------------------------------- |
| **Modular Monolith**            | Single deployable application with clear module boundaries and separation of concerns. |
| **Vertical Slice Architecture** | Organize code by feature/endpoint instead of technical layers.                         |
| **Domain-Driven Design (DDD)**  | Model domains according to real business processes.                                    |
| **CQRS**                        | Separate write (commands) and read (queries) for scalability and maintainability.      |
| **Outbox Pattern**              | Ensures reliable messaging between modules with transactional consistency.             |

### Module Communication

* **Synchronous:** In-process method calls via public APIs
* **Asynchronous:** Event-driven messaging using RabbitMQ & MassTransit

### Security

* **Keycloak** for authentication & authorization
* **OAuth2 + OpenID Connect** flows
* **JWT Bearer Tokens** for API security

## 🗂 Project Modules

### 1. Catalog Module

* ASP.NET Core Minimal APIs with .NET 8 features
* Vertical Slice Architecture with **Feature folders**
* DDD + CQRS using MediatR
* Domain & Integration Events (e.g., `UpdatePriceChanged`)
* EF Core Code-First with PostgreSQL
* Minimal API endpoints using Carter
* Logging, Validation, Exception Handling, Pagination

### 2. Basket Module

* DDD + CQRS + Vertical Slice Architecture
* Redis Distributed Cache over PostgreSQL
* Proxy, Decorator, Cache-aside patterns
* Publishes `BasketCheckoutEvent` to RabbitMQ via MassTransit
* Outbox Pattern for reliable messaging

### 3. Identity Module

* User authentication & authorization via Keycloak
* OAuth2 + OpenID Connect flows
* Docker-compose setup for Keycloak as identity provider
* Secures other modules using JWT Bearer tokens

### 4. Ordering Module

* DDD + CQRS + Vertical Slice Architecture
* Handles BasketCheckout use case
* Implements Outbox Pattern for reliable messaging

## ⚡ Cross-Cutting Concerns

* **Logging:** Serilog
* **Validation:** MediatR Pipeline Behaviors
* **Exception Handling**
* **Caching:** Redis
* **Pagination** built-in

## 🔄 Module Communication Patterns

| Type         | Implementation                                          |
| ------------ | ------------------------------------------------------- |
| Synchronous  | In-process method calls / Public APIs                   |
| Asynchronous | RabbitMQ & MassTransit (e.g., Catalog ↔ Basket updates) |

## 🛠 Tech Stack

* **.NET 8, C# 12**
* **ASP.NET Core Minimal APIs**
* **Entity Framework Core + PostgreSQL**
* **MediatR** for CQRS & Domain Events
* **Redis** for distributed caching
* **RabbitMQ & MassTransit** for event-driven messaging
* **Keycloak** for authentication & authorization
* **Docker & Docker-compose** for local development

## 📦 Implemented Patterns

* Proxy / Decorator / Cache-aside
* Vertical Slice Architecture (Feature folders)
* CQRS with MediatR
* Domain & Integration Events
* Outbox Pattern for reliable messaging

## 🔮 Future Plans

* Migration from Modular Monolith to **Microservices** using the Strangler Fig Pattern
* Additional modules for Payments, Shipping, and Notifications

## 📚 References

* [Vertical Slice Architecture](https://jasontaylor.dev/vertical-slice-architecture/)
* [Domain-Driven Design](https://domainlanguage.com/ddd/)
* [CQRS & MediatR](https://github.com/jbogard/MediatR)
* [Outbox Pattern](https://microservices.io/patterns/data/transactional-outbox.html)
* [Keycloak Documentation](https://www.keycloak.org/documentation)
  
