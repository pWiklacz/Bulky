# Bulky - Book Shop ASP.NET Web Application

## Introduction

Bulky is a web application developed as part of a course project. It serves as a book shop where users can browse, search for, and purchase books online. This repository contains the source code and files required to run the Bulky web application.

## Features

- User-friendly book browsing and searching.
- User registration and authentication.
- Shopping cart functionality to add and manage selected books.
- Checkout process for purchasing books.
- Admin panel for managing books, categories, and users.
- Role-based access control (admin and regular users).

## Prerequisites

Before you can run the Bulky web application, you will need the following:

- Visual Studio with ASP.NET development tools.
- SQL Server or another compatible database server.
- .NET Core runtime installed.

## Getting Started

1. Clone this repository to your local machine:

   ```shell
   git clone https://github.com/your-username/bulky.git
   ```

2. Open the project in Visual Studio.

3. Modify the connection string in `appsettings.json` to point to your database server.

4. Build the project and resolve any dependencies.

5. Run the database migrations to create the necessary tables:

   ```shell
   dotnet ef database update
   ```

6. Start the application in Visual Studio.

7. Access the web application through your preferred web browser at `http://localhost:port` (the port number may vary).

## Usage

- Register as a new user or log in if you already have an account.
- Browse the book catalog, search for books, and add them to your cart.
- Proceed to the checkout page to complete your purchase.
- Admin users can access the admin panel to manage books, categories, and users.

## Contributing

Contributions to the Bulky project are welcome. Feel free to fork this repository, make improvements, and submit pull requests.

## Acknowledgments

The Bulky project was developed as part of a course and may contain code or ideas inspired by other sources. Special thanks to the course instructors and contributors for their guidance and support.

Happy reading and coding! 📚💻
