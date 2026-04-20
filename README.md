# 🚀 Modular Monolith Starter

## 📌 Overview

This repository implements a production-oriented backend system built with .NET 8 and ASP.NET Core Minimal APIs.

The project focuses on demonstrating modern backend architecture, scalability principles, and clean system design rather than feature completeness.

It is designed as a **modular architecture starter foundation**, intended to be used as a baseline for building real-world scalable backend systems without starting from scratch.

It showcases how to build a maintainable, modular, and extensible system using real-world architectural patterns.

---

## 🏗 Architecture Overview

### Core Architectural Patterns

- Modular Monolith Architecture (Modulith)
- Vertical Slice Architecture (VSA)
- Domain-Driven Design (DDD)
- CQRS (Command Query Responsibility Segregation)
- Outbox Pattern for reliable messaging
- Event-driven architecture using RabbitMQ & MassTransit
- Secure APIs using Keycloak (OAuth2 / OpenID Connect / JWT)

---

## 🔄 Communication Patterns

### Synchronous Communication
- In-process module-to-module calls via public APIs

### Asynchronous Communication
- Event-driven messaging using RabbitMQ & MassTransit

---

## 🔐 Security

- Keycloak Identity Provider
- OAuth2 & OpenID Connect
- JWT Bearer Authentication
- Centralized identity management across modules

---

## 🧩 Modules

### 🛒 Catalog Module
- ASP.NET Core Minimal APIs (.NET 8)
- Vertical Slice Architecture (Feature-based structure)
- CQRS with MediatR
- Domain & Integration Events
- EF Core (Code-First) with PostgreSQL
- Validation, Logging, Exception Handling, Pagination

---

### 🧺 Basket Module
- DDD + CQRS + Vertical Slices
- Redis Distributed Cache
- Cache-aside / Proxy / Decorator patterns
- Publishes `BasketCheckoutEvent` via RabbitMQ
- Outbox Pattern for reliable messaging

---

### 🔐 Identity Module
- Keycloak integration for authentication & authorization
- OAuth2 / OpenID Connect flows
- Docker-based Keycloak setup
- Secures all modules using JWT Bearer tokens

---

### 📦 Ordering Module
- Handles checkout workflow
- DDD + CQRS + Vertical Slice Architecture
- Outbox Pattern for reliable event processing
- Event-driven integration with other modules

---

## ⚙️ Cross-Cutting Concerns

- Logging: Serilog  
- Validation: MediatR Pipeline Behaviors  
- Exception Handling  
- Caching: Redis  
- Pagination support  

---

## 🛠 Tech Stack

- .NET 8 / C# 12
- ASP.NET Core Minimal APIs
- Entity Framework Core + PostgreSQL
- MediatR (CQRS & Domain Events)
- Redis (Distributed Caching)
- RabbitMQ + MassTransit
- Keycloak (Identity & Access Management)
- Docker & Docker Compose

---

## 📦 Design Patterns Used

- CQRS
- Vertical Slice Architecture
- Domain-Driven Design (DDD)
- Outbox Pattern
- Proxy Pattern
- Decorator Pattern
- Cache-aside Pattern
- Domain & Integration Events

---

## 🔮 Future Improvements

- Migration to Microservices using Strangler Fig Pattern
- Payments Module
- Shipping Module
- Notification System
- Observability (Logging, Metrics, Tracing)

