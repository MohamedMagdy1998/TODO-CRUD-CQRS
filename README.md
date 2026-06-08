# TODO CRUD API - CQRS Pattern with ASP.NET Core

A clean and maintainable **Todo Management REST API** built with **ASP.NET Core**, implementing the **CQRS (Command Query Responsibility Segregation)** pattern using **MediatR**. This project demonstrates how to separate read and write operations, resulting in a more scalable, testable, and maintainable architecture.

---

##  Features

* Create Todo items
* Retrieve all Todos
* Retrieve Todo by Id
* Update existing Todos
* Delete Todos
* CQRS Architecture
* MediatR Integration
* Entity Framework Core
* SQLLite Database
* Dependency Injection
* Clean Architecture
* RESTful API Design

---

##  Architecture

The project follows the **CQRS Pattern**, where:

### Commands (Write Operations)

Responsible for changing the application's state:

* CreateTodoCommand
* UpdateTodoCommand
* DeleteTodoCommand

### Queries (Read Operations)

Responsible for retrieving data:

* GetAllTodosQuery
* GetTodoByIdQuery

This separation improves maintainability and keeps business logic organized. CQRS is commonly used to isolate read and write concerns and promote high cohesion within application features.

---

##  Project Structure

```text
TODO-CRUD-CQRS
│
├── Commands
│   ├── CreateTodo
│   ├── UpdateTodo
│   └── DeleteTodo
│
├── Queries
│   ├── GetAllTodos
│   └── GetTodoById
│
├── Handlers
│
├── Models
│
├── Data
│
├── Controllers
│
├── Migrations
│
└── Program.cs
```

---

##  Technologies Used

* ASP.NET Core Web API
* C#
* Entity Framework Core
* SQLLite
* MediatR
* CQRS Pattern
* Dependency Injection
* Swagger / OpenAPI
* Fluent Vlidation
---

##  Prerequisites

Before running the project, make sure you have installed:

* .NET SDK 8.0 or later
* SQL Server
* Visual Studio 2022 / VS Code

---

##  Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/MohamedMagdy1998/TODO-CRUD-CQRS.git
```

### 2. Navigate to the Project

```bash
cd TODO-CRUD-CQRS
```

### 3. Configure Connection String

Update your database connection string inside:

```json
appsettings.json
```

Example:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=TodoDb;Trusted_Connection=True;TrustServerCertificate=True"
}
```

### 4. Apply Migrations

```bash
dotnet ef database update
```

### 5. Run the Application

```bash
dotnet run
```

---

##  API Endpoints

### Get All Todos

```http
GET /api/todos
```

### Get Todo By Id

```http
GET /api/todos/{id}
```

### Create Todo

```http
POST /api/todos
```

Request Body:

```json
{
  "title": "Learn CQRS",
  "description": "Study MediatR and CQRS pattern"
}
```

### Update Todo

```http
PUT /api/todos/{id}
```

Request Body:

```json
{
  "title": "Updated Title",
  "description": "Updated Description"
}
```

### Delete Todo

```http
DELETE /api/todos/{id}
```

---

##  CQRS Flow

```text
Client Request
      │
      ▼
 Controller
      │
      ▼
   MediatR
      │
 ┌────┴────┐
 ▼         ▼
Command   Query
Handler   Handler
 ▼         ▼
Database Database
```

---

