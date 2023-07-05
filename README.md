# Al Saadi Bookstore

## Description
Al Saadi Bookstore is a web-based bookstore application developed using ASP.NET MVC, ADO.NET, and Entity Framework. It follows a Database First approach and utilizes Microsoft SQL Server Management Studio 2019 (SSMS) and MySQL as the database query language. Visual Studio 2019 is used to manage the backend of the web application. The application consists of three modules: admin, user, and books.

The admin module allows administrators to perform various tasks such as adding, deleting, updating, and viewing books. The user module is designed for registered users who can browse and purchase books by adding them to their cart. The books module handles the creation and management of book properties. All three modules are synchronized with each other.

## Prerequisites
To run this application, you need to have the following software installed:

- Microsoft SQL Server Management Studio 2019
- Visual Studio 2019
- Create 3 SQL Tables All of the screenshots are provided below:
- Tables that are to be created👇
  ![image](https://github.com/SaadARazzaq/Al-Saadi-Bookstore/assets/123338307/45075d64-8bfd-4223-8777-20d1a3dbc1bf)
1) dbo.addBooks
  ![image](https://github.com/SaadARazzaq/Al-Saadi-Bookstore/assets/123338307/abb3dc4d-088b-4df4-8e47-e83caba8c247)
2) dbo.Admin
  ![image](https://github.com/SaadARazzaq/Al-Saadi-Bookstore/assets/123338307/ebd06c57-e238-47b5-b2a8-2fa8d7a446f9)
3) dbo.addUsers
  ![image](https://github.com/SaadARazzaq/Al-Saadi-Bookstore/assets/123338307/54256573-c7ed-4aab-99c6-6f8534505842)


## Setup Instructions
1. Clone this repository to your local machine or download the source code as a ZIP file.
2. Open the project in Visual Studio 2019.
3. Open the solution file (`20F-0292_BCS 6E_Advanced Programming Final.sln`) from the project root directory.
4. In Visual Studio, open the Package Manager Console (Tools > NuGet Package Manager > Package Manager Console).
5. Run the following command in the Package Manager Console to restore the required NuGet packages:
6. In the Solution Explorer, expand the project and locate the `Web.config` file.
7. Update the connection string in the `Web.config` file with your database server and credentials.
8. Open SQL Server Management Studio 2019 and create a new database using the provided SQL table screenshots to make database tables first in SSMS before running .sln file.
9. Once the database is created, update the connection string in the `Web.config` file to point to the newly created database.
10. Build the solution in Visual Studio (Build > Build Solution).
11. Run the application by pressing F5 or using the Debug menu (Debug > Start Debugging).

Note: Make sure that both SSMS 2019 and Visual Studio 2019 are properly configured and running before executing the above steps.

## Usage
1. Open a web browser and navigate to `http://localhost:<port>` (replace `<port>` with the appropriate port number).
2. The application homepage will be displayed, where you can register as a user or log in as an admin.
3. Once logged in, you can perform the respective tasks based on your role (admin or user).
4. As an admin, you can manage books by adding, deleting, updating, or viewing them.
5. As a user, you can browse books, add them to your cart, and proceed with the purchase.

## License
This project is licensed under the [MIT License](LICENSE).
