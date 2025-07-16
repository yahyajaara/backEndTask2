using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Member : Person
    {
        public List<Book> BorrowedBooks { get; } = new List<Book>();
        public Member(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public void BorrowBook(Book book)
        {
            if (book != null && book.IsAvailable)
            {
                BorrowedBooks.Add(book);
                book.IsAvailable = false;
                Console.WriteLine($"{Name} has borrowed '{book.Title}'");
            }
            else
            {
                Console.WriteLine("Book is not available for borrowing.");
            }
        }
        public void ReturnBook(Book book)
        {
            if (book != null && BorrowedBooks.Contains(book))
            {
                BorrowedBooks.Remove(book);
                book.IsAvailable = true;
                Console.WriteLine($"{Name} has returned '{book.Title}'");
            }
            else
            {
                Console.WriteLine("This book wasn't borrowed by this member.");
            }
        }
        public void DisplayBorrowedBooks()
        {
            Console.WriteLine($"\n{Name}'s Borrowed Books:");
            if (BorrowedBooks.Count == 0)
            {
                Console.WriteLine("No books currently borrowed.");
                return;
            }
            foreach (var book in BorrowedBooks)
            {
                book.DisplayInfo();
            }
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Member ID: {Id}, Name: {Name}");
        }
    }
}
