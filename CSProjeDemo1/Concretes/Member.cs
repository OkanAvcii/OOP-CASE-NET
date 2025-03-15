using CSProjeDemo1.Abstract;
using CSProjeDemo1.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Concretes
{
    public class Member : IMember
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int MemberNo { get; set; }
        public List<Book> Books { get; set; }

        public Member(string name, string surname, int memberNo)
        {
            Name = name;
            Surname = surname;
            MemberNo = memberNo;
            Books = new List<Book>();
        }

        public void KitapIadeEt(Book book)
        {
            if (Books.Contains(book))
            {
                book.Status = Status.OduncAlabilir;
                Books.Remove(book);
                Console.WriteLine($"{book.Title} kitabı iade edildi.");
            }
            else
            {
                Console.WriteLine($"Bu kitabı iade edemezsiniz!");
            }
        }

        public void KitapOduncAl(Book book)
        {
            if (book.Status == Status.OduncAlabilir)
            {
                book.Status = Status.OduncVerildi;
                Books.Add(book);
                Console.WriteLine($"{book.Title} kitabı ödünç alındı.");
            }
            else
            {
                Console.WriteLine($"{book.Title} kitabı ödünç alınamaz.");
            }
        }
    }
}
