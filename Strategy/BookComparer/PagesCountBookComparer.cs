using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class PagesCountBookComparer : IBookComparer
    {
        public int Compare(Book firstBook, Book secondBook)
        {
            return firstBook.PagesCount - secondBook.PagesCount;
        }
    }
}
