**Languages:**  
[🇺🇸 English](README.md) | [🇬🇹 Español](README.es.md)

# Enterprise .NET Architecture Template

A robust, enterprise-grade architectural baseline powered by Clean Architecture, featuring modular, scalable, and fully testable .NET components — engineered by [Luis López](https://github.com/luislopez-dev).

This template provides a clean, extensible structure that accelerates the development of **internal corporate systems and mission-critical business software**.

**If you find this architecture valuable, please consider giving it a star ⭐. Your support helps me continue improving and expanding this template with new capabilities and enterprise-level features.**

---

[![Architecture Template Demo](https://img.youtube.com/vi/BXW7uFoATsk/0.jpg)](https://www.youtube.com/watch?v=-BXW7uFoATsk)

---

## Architecture Overview

The solution is organized into independent, clearly-defined layers, each designed to enforce separation of concerns, testability, and maintainability at scale:

<img width="750" height="400" alt="enterprise-dotnet-architecture" src="https://github.com/user-attachments/assets/e106d323-4e53-4085-9be0-af0e9a09146c" />


### **Presentation**
Handles API endpoints, request/response models, controllers, and cross-cutting concerns related to delivery.

### **Application**
Contains the core use cases, business rules, application logic and orchestration.

### **Business**
Domain logic, entities and domain-specific behavior. Independent from infrastructure and UI concerns.

### **Infrastructure**
Implements external integrations: data persistence, repositories, external services, messaging, authentication providers, etc.

---

## Test-Driven Structure

Each layer includes its own dedicated test project to ensure isolation, stability, and long-term reliability:

- `Presentation.Tests`
- `Application.Tests`
- `Business.Tests`
- `Infrastructure.Tests`

This template is designed for organizations that value **quality, reproducibility, and long-term maintainability**.

---

## DevOps & Automation Ready

This template includes built-in support for modern DevOps workflows, enabling fast provisioning, reliable development environments, and continuous integration out of the box.

### **Docker & Containerization**
- Preconfigured **Dockerfile** for the application
- **docker-compose** setup for orchestrating services
- Includes **SQL Server** container support for local and integration environments

These components provide a consistent, reproducible, and production-oriented environment from day one.

### **GitHub Actions CI Pipeline**
A streamlined GitHub Actions workflow is included to automate:

- Dependency restoration
- Solution build
- Layer-specific test execution

This ensures code quality, reliability, and architectural integrity across the entire solution.

<img width="820" height="880" alt="Captura de pantalla (271)" src="https://github.com/user-attachments/assets/7611cfe8-ac4b-4cd7-a189-8e0d97092697" />

---

## Key Principles

- **Clean Architecture**
- **SOLID Design**
- **Test-Driven Development Support**
- **Layered Isolation**
- **Plug-and-Play Extensibility**
- **Enterprise-Ready Structure for Large Solutions**

The code is structured to grow with your application — not constrain it.

---

## Ideal For

- Companies modernizing legacy systems
- Teams that need a proven architectural baseline
- Developers who want to accelerate enterprise-level .NET projects

This is a **foundation**, not a full product.  
It is designed for teams that need a **high-caliber starting point** to build serious, scalable applications.

---

## Why This Template Exists

Architectural decisions done incorrectly early in a project create friction, technical debt, and long-term limitations.

This template exists to provide:

- A **strong, future-proof architecture**
- A **consistent modular structure**
- A **realistic enterprise environment**
- A **solid testing strategy for all layers**

Use it as a base. Adapt it. Extend it.

---

## Enterprise Support & Consulting

If your organization needs:

- Architectural guidance
- Custom integrations
- Scalable backend design
- Cloud-native migration
- Performance optimization
- Full enterprise support

You can reach me at:

**luis.dev.master@gmail.com**

---

## Build strong foundations. Deliver scalable systems.  

---

### Crafted and maintained by [Luis López](https://github.com/luislopez-dev)



