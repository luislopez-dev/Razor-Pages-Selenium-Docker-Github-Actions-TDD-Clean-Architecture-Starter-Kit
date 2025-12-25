# **Software & DevOps Architecture in .NET**
# <sub> Powered by Selenium, CA Principles, TDD, Docker & GitHub Actions </sub>

## Introduction

<strong>This project demonstrates a core foundation for building enterprise web applications with integrated DevOps capabilities.</strong>

Some patterns like DTOs and isolated Use Cases were omitted due to time constraints. I’m archiving it as a structural reference.

This is an evolutionary architecture built with a pragmatic approach; as such, there will never be a 'final' version. I will continue to refine the engineering as time permits and based on the number of stars ⭐ this repository receives.

## Structure

<img width="502" height="666" alt="Project (2)" src="https://github.com/user-attachments/assets/94f83562-dd4e-4bc9-b52b-e6d430d5940b" />

### Domain

<strong>Contains the core business rules.</strong>

The adoption of DDD principles for this layer is currently being evaluated for a potential update.

### Application

<strong>Defines the application services and coordinates communication between the presentation layer and the business logic.</strong>

The services in this project might be refactored into individual use cases, 
and the whole layer might be refactored with a Vertical-Slice approach in future updates.

### Infrastructure

<strong>Implements technical details such as data access and external services.</strong>

The repositories in this template could be refactored through a generic repository in the future.

### Presentation

<strong>Contains the logic that handles user interaction.</strong>

## DevOps

The repository includes a CI pipeline built with GitHub Actions. This workflow automates test execution and verifies that every change meets the defined standards. 

<img width="902" height="666" alt="Project (2)" src="https://github.com/user-attachments/assets/f614ae39-3be4-493f-9483-d5f1c41de957" />

## Business Logic

This project emulates an inventory and billing management system.

## Development Approach
The solution follows a TDD-oriented workflow, incorporating unit and integration tests to validate key components and ensure code quality from the early stages of development. In addition, end-to-end tests are implemented using Selenium to verify critical user flows in a real browser environment.

## Runtime Environment
To simplify setup and ensure consistency across environments, the project uses Docker Compose. The configuration includes support for SQL Server, allowing you to easily replicate a realistic database environment for both development and testing.

## YouTube Video
For a short demonstration, I recorded the following video:

[Watch on YouTube](https://youtu.be/0nfXpb7OsPA?si=28_t2m6mDIMfSiVw)

## Project created by [Luis López](https://github.com/luislopez-dev)
