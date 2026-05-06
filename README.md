# Modular Monolith Starter

A production-ready backend architecture starter built with modern .NET technologies and best practices.

## Overview

This project demonstrates how to build a scalable, maintainable backend system using a **Modular Monolith architecture**.

It is designed as a **real-world foundation** that can evolve into microservices without requiring a complete rewrite.

## Architecture & Patterns

- Modular Monolith (Modulith)
- Vertical Slice Architecture (VSA)
- Domain-Driven Design (DDD)
- CQRS (Command Query Responsibility Segregation)
- Event-Driven Architecture
- Outbox Pattern (Reliable Messaging)

## Tech Stack

- .NET 8
- ASP.NET Core Minimal APIs
- Entity Framework Core + PostgreSQL
- MediatR
- Redis (Distributed Caching)
- RabbitMQ + MassTransit
- Keycloak (OAuth2 / OpenID Connect / JWT)
- Docker & Docker Compose

## Security

- Centralized authentication using Keycloak
- OAuth2 & OpenID Connect
- JWT Bearer Authentication
- Secured module communication

## Modules

### Catalog
- Product management
- CQRS + Vertical Slices
- EF Core + PostgreSQL

### Basket
- Redis distributed caching
- Cache-aside / Proxy / Decorator patterns
- Publishes checkout events

### Ordering
- Handles checkout workflow
- Event-driven processing
- Outbox pattern implementation

### Identity
- Keycloak integration
- Authentication & authorization
- Docker-based setup

## Communication

### Synchronous
- In-process module communication

### Asynchronous
- Event-driven messaging using RabbitMQ & MassTransit

## Cross-Cutting Concerns

- Logging (Serilog)
- Validation (MediatR Pipeline Behaviors)
- Exception Handling
- Caching
- Pagination

## Getting Started

### Prerequisites
- .NET 8 SDK
- Docker & Docker Compose

### Run the project

```bash
docker-compose up --build