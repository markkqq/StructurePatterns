using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Menu
    {
        Library library;
        public void ShowBooks()
        {
            foreach(Book book in library.Books)
            {
                Console.WriteLine(@"Название {0}, автор - {1}, страниц - {2}",book.Title, book.Author,book.PagesCount);
            }
            Console.WriteLine("-------------------");
        }
        public void SortBooks(SortingAlgorithm sortingAlgorithm, IBookComparer bookComparer)
        {
            library.Books = sortingAlgorithm.Sort(library.Books, bookComparer);

        }
        public Menu(Library library)
        {
            this.library = library;
        }
    }
}
