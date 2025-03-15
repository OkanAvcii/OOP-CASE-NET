using CSProjeDemo1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Concretes
{
    public class Library
    {
        public List<Book> Books { get; }
        public List<Member> Members { get; }

        public Library()
        {
            Books = new List<Book>();
            Members = new List<Member>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void AddMember(Member member)
        {
            Members.Add(member);
        }

        public void KutuphaneDurumuGoster()
        {
            Console.WriteLine("Books:");
            foreach (var book in Books)
            {
                Console.WriteLine($"{book.Title} - {book.Status}");
            }
        }
    }
}
