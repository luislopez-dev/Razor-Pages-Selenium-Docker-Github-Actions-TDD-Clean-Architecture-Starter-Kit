# **Software & DevOps Architecture in .NET**

# <sub> Powered by Selenium, CA Principles, Docker & GitHub Actions </sub>

## Engineered by [Luis René López](https://github.com/luislopez-dev)

## Introduction

<strong>This repository is intended for educational and experimental purposes only. It is not production-ready and should not be used in live or critical environments.</strong>

Some patterns like Dto pattern and isolated use cases have been omitted due to time constraints. I might continue to refine this project in future updates.

## Business Logic

This project emulates an inventory and billing management system.

<img width="502" height="666" alt="Project (2)" src="https://github.com/user-attachments/assets/3f4cfc0b-f3db-4386-9957-512fa464e485" />

## Software architecture

<img width="502" height="666" alt="Project (2)" src="https://github.com/user-attachments/assets/94f83562-dd4e-4bc9-b52b-e6d430d5940b" />

### Domain

Contains the core business rules.

### Application

Defines the application services and coordinates communication between the presentation layer and the business logic.

### Infrastructure

Implements technical details such as data access and external services.

### Presentation

Contains the logic that handles user interaction.

## DevOps

The repository includes a CI pipeline built with GitHub Actions. This workflow automates test execution and verifies that every change meets the defined standards. The pipeline additionally containerizes the project with Docker and deploys the resulting image to Docker Hub.

<img width="902" height="666" alt="Project (2)" src="https://github.com/user-attachments/assets/f614ae39-3be4-493f-9483-d5f1c41de957" />

## Runtime Environment
The project uses Docker Compose 🐋 for consistent environment setup. This includes SQL Server support, enabling easy replication of realistic database environments for both development and testing.

## Testing
The solution follows a TDD workflow with unit and integration tests to ensure early code quality 🧪. Additionally, Selenium is used for end-to-end testing to verify critical user flows in a real browser.

## YouTube Video
For a short demonstration, I recorded the following video:

[Watch on YouTube](https://youtu.be/0nfXpb7OsPA?si=28_t2m6mDIMfSiVw)

## Project created by [Luis López](https://github.com/luislopez-dev)
