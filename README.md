📘 Project: Book Library System in C# with SQL Server
🔧 Purpose of the Project
The goal of this project is to create a small library system where you can:

Add books (title and author)

View all books saved in a database

You are using:

C# as the programming language (to build the app)

SQL Server as the database (to store data)

Visual Studio as the IDE (to write and run your code)

🧱 How the Project is Structured
This project is a Console App, which means it runs in the black-and-white command prompt window. You interact with the program by typing numbers and text.

⚙️ Step-by-Step Working
🔹 Step 1: Program Starts
When you run the program, you see this menu:

pgsql
Copy
Edit
1. Add Book
2. Show All Books
3. Exit
You choose an option by entering 1, 2, or 3.

🔹 Step 2: Add Book
If you enter 1, the program runs the AddBook() function.

What happens:

It asks: “Enter Book Title”

You type something like: C# Programming

It then asks: “Enter Author Name”

You type something like: John Smith

The program opens a connection to your SQL Server database

It runs this SQL command:

sql
Copy
Edit
INSERT INTO Books (Title, Author) VALUES ('C# Programming', 'John Smith')
The book is now saved in the database!

🔹 Step 3: Show All Books
If you enter 2, the program runs the ShowBooks() function.

What happens:

It connects to the database

It runs this SQL command:

sql
Copy
Edit
SELECT * FROM Books
It reads the results and displays them like this:

yaml
Copy
Edit
-- Book List --
ID: 1, Title: C# Programming, Author: John Smith
ID: 2, Title: Learn SQL, Author: Sarah Khan
You now see all books stored in the system.

🔹 Step 4: Exit
If you enter 3, the program stops.

🧰 Tools Used
Tool	Purpose
Visual Studio	To write and run your C# code
SQL Server Express/LocalDB	To store your data
SSMS (SQL Server Management Studio)	To create and view your database
C# Language	To create the logic of the application
ADO.NET	To connect C# to SQL Server database

🗃️ Database Details
Database Name: LibraryDB

Table Name: Books

Table Columns:

Id: number (automatically increases)

Title: text (name of the book)

Author: text (who wrote it)

📦 Important C# Concepts Used
Concept	Explanation
SqlConnection	Connects C# app to SQL Server
SqlCommand	Sends SQL queries to the database
SqlDataReader	Reads data returned by a SELECT query
Console.ReadLine()	Takes user input
while(true)	Keeps showing the menu until the user exits