using System;
using lab;
using Strategy;
namespace StructurePatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            SortingAlgorithm sortingAlgorithm = new();
            Library library = new();
            Menu menu = new(library);
            menu.ShowBooks();
            
            PagesCountBookComparer pagesCountBookComparer = new();
            TitleBookComparer bookComparer = new();
            menu.SortBooks(sortingAlgorithm, pagesCountBookComparer);
            menu.ShowBooks();
            menu.SortBooks(sortingAlgorithm,bookComparer);
            menu.ShowBooks();
        }
    }
}
