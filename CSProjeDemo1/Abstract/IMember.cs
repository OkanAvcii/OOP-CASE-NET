using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Abstract
{
    public interface IMember
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int MemberNo { get; set; }
        public List<Book> Books { get; set; }

        void KitapOduncAl(Book book);
        void KitapIadeEt(Book book);
    }
}
