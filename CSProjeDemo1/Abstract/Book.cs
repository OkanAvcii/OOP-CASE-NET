using CSProjeDemo1.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Abstract
{
    public abstract class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublishDate { get; set; }
        public Status Status { get; set; }

        public Book(string isbn, string title, string author, int publishDate)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            publishDate = publishDate;
            Status = Status.OduncAlabilir;
        }
    }
}
