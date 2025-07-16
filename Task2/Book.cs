using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public bool IsAvailable { get; set; } = true;
        public Book(int id, string title, string authorName)
        {
            Id = id;
            Title = title;
            AuthorName = authorName;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Title: {Title}, Author: {AuthorName}, Available: {(IsAvailable ? "Yes" : "No")}");
        }
    }
}
