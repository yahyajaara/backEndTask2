using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Library
    {
        public List<Book> Books { get; } = new List<Book>();
        public List<Person> Members { get; } = new List<Person>();
        public void AddBook(Book book)
        {
            Books.Add(book);
        }
        public void AddMember(Person member)
        {
            Members.Add(member);
        }
        public Book FindBookById(int id)
        {
            return Books.Find(b => b.Id == id);
        }
        public Person FindMemberById(int id)
        {
            return Members.Find(m => m.Id == id);
        }
        public void DisplayAllBooks()
        {
            Console.WriteLine("\nAll Books in Library:");
            foreach (var book in Books)
            {
                book.DisplayInfo();
            }
        }
        public void DisplayAllMembers()
        {
            Console.WriteLine("\nAll Library Members:");
            foreach (var member in Members)
            {
                member.DisplayInfo();
            }
        }
    }
}
