using System;
using System.Data.SqlClient;

class Program
{
    static string connectionString = @"Server=.\SQLEXPRESS;Database=LibraryDB;Trusted_Connection=True;";

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n1. Add Book\n2. Show All Books\n3. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddBook();
                    break;
                case "2":
                    ShowBooks();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    static void AddBook()
    {
        Console.Write("Enter Book Title: ");
        string title = Console.ReadLine();
        Console.Write("Enter Author Name: ");
        string author = Console.ReadLine();

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "INSERT INTO Books (Title, Author) VALUES (@Title, @Author)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Title", title);
            cmd.Parameters.AddWithValue("@Author", author);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            Console.WriteLine("Book added successfully.");
        }
    }

    static void ShowBooks()
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "SELECT * FROM Books";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("\n-- Book List --");
            while (reader.Read())
            {
                Console.WriteLine($"ID: {reader["Id"]}, Title: {reader["Title"]}, Author: {reader["Author"]}");
            }

            reader.Close();
            conn.Close();
        }
    }
}
