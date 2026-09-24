# CRUD Operation Application

A web-based CRUD (Create, Read, Update, Delete) application developed using C#, .NET, HTML, CSS, JavaScript, and Microsoft SQL Server. The application provides a simple and efficient way to manage records through a user-friendly interface.

## 📌 Project Overview

This project demonstrates the implementation of basic CRUD operations in a web application.

Users can:

* Create new records
* View existing records
* Update records
* Delete records
* Manage data through a simple web interface

The application connects the frontend with the .NET backend and SQL Server database to perform data operations.

## 🚀 Features

* Create new records
* View all records
* View individual records
* Update existing records
* Delete records
* Form validation
* Database integration
* User-friendly interface
* Responsive web design

## 🛠️ Technologies Used

### Backend

* C#
* .NET / ASP.NET Core
* Entity Framework Core

### Frontend

* HTML5
* CSS3
* JavaScript

### Database

* Microsoft SQL Server

### Tools

* Visual Studio
* SQL Server Management Studio
* Git
* GitHub

## 📂 Project Structure

```text
CRUD-Operation/
│
├── Controllers/
│   └── ...
│
├── Models/
│   └── ...
│
├── Views/
│   └── ...
│
├── wwwroot/
│   ├── css/
│   ├── js/
│   └── ...
│
├── Data/
│   └── ...
│
├── Program.cs
├── appsettings.json
├── .gitignore
└── README.md
```

> The folder structure may vary depending on the project architecture.

## 🔄 CRUD Operations

### Create

Allows users to add new records to the database.

### Read

Displays existing records from the database.

### Update

Allows users to modify existing records.

### Delete

Allows users to remove records from the database.

## 🗄️ Database

The application uses Microsoft SQL Server to store application data.

The database connection is configured in:

```text
appsettings.json
```

Example:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Your SQL Server Connection String"
  }
}
```

Do not commit passwords or other sensitive database credentials to GitHub.

## ⚙️ How to Run the Project

### 1. Clone the Repository

```bash
git clone https://github.com/Sabir1955/CRUD-Operation.git
```

### 2. Open the Project

Open the project in Visual Studio.

### 3. Configure the Database

Update the connection string in:

```text
appsettings.json
```

with your SQL Server configuration.

### 4. Apply Database Migrations

If Entity Framework Core migrations are used, run:

```bash
dotnet ef database update
```

### 5. Run the Application

Run the application using Visual Studio or:

```bash
dotnet run
```

### 6. Open the Application

Open the URL shown in the terminal or Visual Studio output.

## 📸 Screenshots

Add screenshots of your application here.

Example:

```text
screenshots/
├── home.png
├── create.png
├── edit.png
└── list.png
```

You can then add them to the README:

```markdown
![Home Page](screenshots/home.png)
```

## 🎯 Learning Objectives

This project was created to practice:

* C# programming
* ASP.NET Core / .NET development
* CRUD operations
* Database connectivity
* Entity Framework Core
* SQL Server
* HTML and CSS
* JavaScript
* MVC/Web application architecture
* Git and GitHub

## 🔮 Future Improvements

Possible future enhancements include:

* User authentication
* Role-based authorization
* Search and filtering
* Pagination
* Advanced validation
* REST API integration
* Improved UI/UX
* Logging and error handling

## 👨‍💻 Author

**Gulam Sabir**



