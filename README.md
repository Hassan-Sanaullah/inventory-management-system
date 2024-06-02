# Inventory Management System

## Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Database Schema](#database-schema)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)

## Overview

The Inventory Management System is a C# application designed to manage inventory, orders, and users. It provides features for user authentication, product management, order tracking, and sales data analysis.

## Features

- **User Authentication**: Login and register functionality.
- **Product Management**: Add, delete, and filter products.
- **Order Management**: View and filter orders.
- **Sales Data Analysis**: Retrieve sales data and revenue by date.
- **Database Connection**: Secure connection to a local SQL Server database.

## Installation

### Prerequisites

- [.NET Framework](https://dotnet.microsoft.com/download)

### Steps

1. **Clone the repository**:
    ```bash
    git clone https://github.com/your-username/inventory-system.git
    ```

2. **Open the solution**:
    Open the `inventory_system.sln` file in Visual Studio.

3. **Configure the database**:
    - Ensure that the database file `inventory_system.mdf` is correctly attached in your SQL Server.

4. **Update the connection string**:
    - Modify the `connectionString` in `AccessDB.cs` if necessary:
      ```csharp
      private readonly string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\path\\to\\your\\database\\inventory_system.mdf\";Integrated Security=True;Connect Timeout=30";
      ```

5. **Build and run the application**:
    - Build the solution in Visual Studio and run the application.

## Usage

### Login

- Open the application.
- Enter your email and password.
- Click on the "Login" button.

### Register

- Open the application.
- Click on the "Register" link.
- Fill in your details and click on the "Register" button.

### Add Product

- Navigate to the product management section.
- Fill in the product details.
- Click on the "Add Product" button.

### Delete Product

- Navigate to the product management section.
- Select the product to delete.
- Click on the "Delete" button.

### Filter Products

- Navigate to the product management section.
- Use the filter options to search for products.
- Click on the "Filter" button.

### View Orders

- Navigate to the orders section.
- View the list of all orders.

### Filter Orders

- Use the filter options to search for specific orders.
- Click on the "Filter" button.

### Sales Data

- Navigate to the sales data section.
- Enter the date to retrieve sales data.
- Click on the "Get Data" button.


## Database Schema

### Tables

- **users**:
  - `user_id`: int, primary key
  - `email`: nvarchar(255)
  - `password`: nvarchar(255)
  - `full_name`: nvarchar(255)
  - `role`: nvarchar(50)

- **products**:
  - `product_id`: int, primary key
  - `name`: nvarchar(255)
  - `description`: nvarchar(MAX)
  - `price`: decimal
  - `rating`: float
  - `color`: nvarchar(50)
  - `image`: varbinary(MAX)
  - `stock_quantity`: int

- **orders**:
  - `order_id`: int, primary key
  - `order_date`: datetime
  - `total_amount`: decimal
  - `order_status`: nvarchar(50)

- **order_items**:
  - `order_item_id`: int, primary key
  - `order_id`: int, foreign key
  - `product_id`: int, foreign key
  - `quantity`: int
  - `price`: decimal

## Contributing

Contributions are welcome! Please fork the repository and create a pull request with your changes. Make sure to follow the coding standards and write appropriate tests.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Contact

For any questions or suggestions, please contact:

- **Name**: Hassan Sanaullah
- **GitHub**: [Hassan-Sanaullah](https://github.com/Hassan-Sanaullah)


