# Bulky - Book Shop ASP.NET Web Application

## Introduction

Bulky is a web application developed as part of a course project. It serves as a book shop where users can browse, search for, and purchase books online. This repository contains the source code and files required to run the Bulky web application.
Here is a link for a course site:
https://www.udemy.com/course/complete-aspnet-core-21-course/

## Features

- User-friendly book browsing and searching.
- User registration and authentication.
- Login with FaceBook or Microsoft accounts.
- Shopping cart functionality to add and manage selected books.
- Checkout process for purchasing books.
- Role-based access control (admin and regular users).
- Admin panel for managing books, categories, and users.
- Admin panel for managing orders and payments.

## Prerequisites

Before you can run the Bulky web application, you will need the following:

- Visual Studio with ASP.NET development tools.
- SQL Server or another compatible database server.
- .NET Core runtime installed.
- **Stripe Account**: You must have a Stripe account to process payments. If you don't have one, you can sign up for a free account at [Stripe](https://stripe.com).

## Getting Started

1. Clone this repository to your local machine:

   ```shell
   git clone https://github.com/pWiklacz/bulky.git
   ```

2. Open the project in Visual Studio.

3. Modify the connection string in `appsettings.json` to point to your database server.

4. To configure the application to work with your Stripe account, follow these steps:

 - Open the `appsettings.json` file in the project.

 - Locate the section for Stripe API keys:

   ```json
   "Stripe": {
       "PublicKey": "YOUR_PUBLIC_KEY",
       "SecretKey": "YOUR_SECRET_KEY"
   }

- Replace "YOUR_PUBLIC_KEY" and "YOUR_SECRET_KEY" with your actual Stripe API keys.

- Save the appsettings.json file.

5. Build the project and resolve any dependencies.

6. Run the database migrations to create the necessary tables:

   ```shell
   dotnet ef database update
   ```

7. Start the application in Visual Studio.

8. Access the web application through your preferred web browser at `http://localhost:port` (the port number may vary).

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
