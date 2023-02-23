using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Book
    {
        public string Title { get; }
        public int PagesCount { get; }
        public string Author { get; }
        public Book(string title, int pagesCount,string author)
        {
            Title = title;
            PagesCount = pagesCount;
            Author = author;
        }
    }
}
