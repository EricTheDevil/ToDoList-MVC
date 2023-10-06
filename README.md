ToDoList-MVC with PostgreSQL and Entity Framework

Table of Contents
Introduction
Prerequisites
Installation
Usage
API Endpoints
Contributing
License
Introduction
This project is a To-Do List application built with ASP.NET MVC, utilizing PostgreSQL as the database and Entity Framework as the ORM. This README provides instructions on setting up and running the application.

Prerequisites
.NET SDK
PostgreSQL Database
Postman (for API testing)
Installation
Configure PostgreSQL Database

Create a new PostgreSQL database with the following parameters:


Database=postgres; 
Username=postgres; 
Password=test123
Update appsettings.json with your database configuration.

Run Migrations

Open the Package Manager Console and run:

Add-Migration
Update-Database
Start the Application

Run IIS or start the application through your IDE.

Usage
Registration
You need to register before you can access the API. Use Postman to hit the registration endpoint:

POST http://localhost:24288/api/v1/Authentication/signup
Request Body:

{
  "username": "your_username",
  "email": "your_email",
  "password": "your_password",
  "createdTime": "string"
}
Note: Password must contain at least one capital letter, 8 characters, and one special character.

Login
After registering, login to receive a JWT token:

POST http://localhost:24288/api/v1/Authentication/signin
Request Body:

{
  "username": "your_username",
  "password": "your_password"
}
Copy the JWT token for further requests.

API Endpoints
Create a New To-Do Item: [POST] /api/v1/ToDoItem
Get an Item by ID: [GET] /api/ToDoItem/{id}
Update an Item: [PUT] /api/ToDoItem/{id}
Delete an Item: [DELETE] /api/ToDoItem/{id}
Get Items by Status: [GET] /api/v1/ToDoItem?status={status}
Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

License
This project is licensed under the MIT License. See the LICENSE.md file for details.
