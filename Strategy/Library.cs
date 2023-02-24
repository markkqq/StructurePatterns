using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Library
    {
        public List<Book> Books { get; set; } = new()

        {
            new Book("aaa", 120, "authorggg"),
            new Book("zzz", 110, "aoo1"),
            new Book("ccc", 90, "author1"),
            new Book("bbb", 150, "adsfadf")
        };

    }
}
