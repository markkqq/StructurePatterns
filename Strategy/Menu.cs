using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Menu
    {
        Library library;
        public void ShowBooks()
        {

        }
        public void SortBooks(SortingAlgorithm<string> sortingAlgorithm,int type)
        {
            

        }
        public Menu(Library library)
        {
            this.library = library;
        }
    }
}
