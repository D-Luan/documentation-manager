# Documentation Manager

![license](https://img.shields.io/badge/license-GNU%20v3.0-yellow)
![C#](https://img.shields.io/badge/language-C%23-purple)
![.NET](https://img.shields.io/badge/framework-.NET%209-blue)
![status](https://img.shields.io/badge/status-in%20progress-green)

## Topics

- [Description](#description)
- [Features](#features)
- [Roadmap](#roadmap)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Download](#download)
- [Stack](#stack)
- [License](#license)


## Description

The Documentation Manager is an API designed to optimize developer and student productivity by centralizing access to important learning resources. Instead of repeatedly searching for links to technology documentation, articles, or tutorials, this application allows you to register, organize, and manage all of your essential links in one place. The goal is to create a personal knowledge hub that makes problem-solving more agile and easier.

## Features

The API allows for the complete management of a personal collection of documentation links, with the following features:

- **Full CRUD Management for Links:**
  - **Create:** Add a new documentation link.
  - **Read:** List all links or fetch a specific link by its ID.
  - **Update:** Update the information of an existing link.
  - **Delete:** Remove a link from the collection.
- **Secure Data Model:** Utilizes DTOs (Data Transfer Objects) to validate input and protect the API against over-posting attacks.

## Roadmap

The vision for the Documentation Manager is to evolve it into an even more powerful productivity tool. The planned future phases include:

- **v1.1 - Quality & Testing:**
  - [ ] Implement unit tests for the Service Layer to ensure business logic reliability.
  - [ ] Configure a logging system to monitor important events and errors.

- **v2.0 - Intelligent Search:**
  - [ ] Integrate with external APIs (e.g., Google Search, OpenAI) to allow for semi-automatic searching and adding of official documentation links.
  - [ ] Implement a tagging system for better organization and filtering of links.

- **v3.0 - User Authentication:**
  - [ ] Add a user registration and login system so that multiple users can have their own private collections of links.

## Prerequisites

You will need the following tools installed on your machine:
* [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
* [PostgreSQL](https://www.postgresql.org/download/)
* [Visual Studio 2022](https://visualstudio.microsoft.com/vs/)

## Installation

1. **Clone the repository:** `https://github.com/D-Luan/documentation-manager.git`

2. **Navigate to the WebAPI project folder:** `cd src/DocumentationManager.WebAPI`

3. **Initialize User Secrets:** `dotnet user-secrets init`

4. **Set your connection string:** `dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Host=localhost;Database=YourDbName;Username=YourUser;Password=YourPassword;"`

5. **Apply the Database Migrations:** `dotnet ef database update`

6. **Run the Application:** `dotnet run`

## Download

Link to download the project as a .zip file: https://codeload.github.com/D-Luan/documentation-manager/zip/refs/heads/main

## Stack

- **Technologies**: C#, .NET 9, ASP.NET Core Web API, PostgreSQL, Entity Framework Core, LINQ
- **Tools**: Git, GitHub, Visual Studio 2022, Postman, Swagger/OpenAPI
- **Methodology**: Kanban, Trello

## License

Distributed under the GNU GENERAL PUBLIC LICENSE v3.0. See the [LICENSE](./LICENSE) for more information.