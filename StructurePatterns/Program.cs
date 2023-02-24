using System;
using lab;
using Strategy;
using Decorator;
namespace StructurePatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Strategy

            /*SortingAlgorithm sortingAlgorithm = new();
            Library library = new();
            Menu menu = new(library);
            menu.ShowBooks();

            PagesCountBookComparer pagesCountBookComparer = new();
            TitleBookComparer bookComparer = new();
            menu.SortBooks(sortingAlgorithm, pagesCountBookComparer);
            menu.ShowBooks();
            menu.SortBooks(sortingAlgorithm, bookComparer);
            menu.ShowBooks();*/

            #endregion
            #region Decorator
            BeveragePriceCalculator beveragePriceCalculator = new();
            Beverage beverage = new() { Price = 50 };
            Chocolate chocolate = new(beveragePriceCalculator);
            Milk milk = new(chocolate);
            Syrup syrup = new(milk);
            Console.WriteLine(syrup.CalculatePrice(beverage)); 
            #endregion
        }
    }
}
