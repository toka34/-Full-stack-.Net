using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_08
{
    public class Book
    {
        // Attributes
        public string Title { get; set; }
        public string Author { get; set; }

        // Default constructor
        public Book()
        {
            Title = "Unknown Title";
            Author = "Unknown Author";
        }

        // Constructor that takes only Title
        public Book(string title)
        {
            Title = title;
            Author = "Unknown Author";
        }

        // Constructor that takes both Title and Author
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        // Override ToString for easy display
        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}";
        }
    }
}
