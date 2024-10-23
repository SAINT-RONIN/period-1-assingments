using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    internal class Library
    {
        public Book[] books;
        int currentCount;

        public Library(int capacity)
        {
            books = new Book[capacity];
            currentCount = 0;
        }

        public void AddBook(Book book)
        {
            if (currentCount < books.Length) // Check if there's space
            {
                books[currentCount] = book; // Add the book
                currentCount++; // Increment the count
            }
            else
            {
                Console.WriteLine("Library is full, cannot add more books.");
            }
        }

        public void DisplayBooks()
        {
            Console.WriteLine("Books in library:");
            for (int i = 0; i < currentCount; i++)
            {
                Console.WriteLine($"{books[i].Title} by {books[i].Author}"); // Print each book's title and author
            }
        }

    }
}
