// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace LibraryManagementConsoleApp
{
    public class Book
    {
        public string? title = null;
        public string? author { get; set; }
        public int id;

    }
    class Program
    {
        static List<Book> books = new List<Book>();

        static void Main(string[] args)
        {
            bool exit = true;
            while (exit)
            {
                Console.WriteLine("Library Management Console App");
                Console.WriteLine("1. Add a book");
                Console.WriteLine("2. Display all books");
                Console.WriteLine("3. Search a book");
                Console.WriteLine("4. Delete a book");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        AddBook();
                        break;
                    case 2:
                        DisplayBooks();
                        break;
                    case 3:
                        SearchBook();
                        break;
                    case 4:
                        DeleteBook();
                        break;
                    case 5:
                        Console.WriteLine("Thank You.");
                        exit = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void AddBook()
        {
            Book newBook = new Book();
            Console.Write("Enter the book title: ");
            newBook.title = Console.ReadLine();
            Console.Write("Enter the book author: ");
            newBook.author = Console.ReadLine();
            Console.Write("Enter the book id: ");
            newBook.id = Convert.ToInt32(Console.ReadLine());

            books.Add(newBook);

            Console.WriteLine("Book added successfully!");
        }

        static void DisplayBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books available.");
            }
            else
            {
                Console.WriteLine("Book List:");
                foreach (Book book in books)
                {
                    Console.WriteLine($"title: {book.title}");
                    Console.WriteLine($"author: {book.author}");
                    Console.WriteLine($"id: {book.id}");
                    Console.WriteLine();
                }
            }
        }

        static void SearchBook()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books available to search.");
            }
            else
            {
                Console.Write("Enter the book id to search: ");
                int find = Convert.ToInt32(Console.ReadLine());

                bool bookFound = false;
                foreach (Book book in books)
                {
                    if (book.id == find)
                    {
                        Console.WriteLine($"title: {book.title}");
                        Console.WriteLine($"author: {book.author}");
                        Console.WriteLine($"id: {book.id}");
                        Console.WriteLine();
                        bookFound = true;
                        break;
                    }
                }

                if (!bookFound)
                {
                    Console.WriteLine("Book not found.");
                }
            }
        }

        static void DeleteBook()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books available to delete.");
            }
            else
            {
                Console.Write("Enter the book id to delete: ");
                int del = Convert.ToInt32(Console.ReadLine());

                bool bookFound = false;
                for (int i = 0; i < books.Count; i++)
                {
                    if (books[i].id == del)
                    {
                        books.RemoveAt(del - 1);
                        books[i].id -- ; 
                        Console.WriteLine("Book deleted successfully!");
                        bookFound = true;
                        break;
                    }
                } 

                if (!bookFound)
                {
                    Console.WriteLine("Book not found.");
                }
            }
        }
    }
}

