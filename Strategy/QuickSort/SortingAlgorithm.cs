using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class SortingAlgorithm
    {
        public List<Book> Sort(List<Book> unsorted, IBookComparer bookComparer)
        {
            if (unsorted.Count == 0 | unsorted.Count == 1)
            {
                return unsorted;
            }

            List<Book> lesser = new();
            List<Book> equal = new();
            List<Book> greater = new();

            Book baseElement = unsorted[0];

            foreach(Book element in unsorted)
            {
                int compareResult = bookComparer.Compare(baseElement,element);
                if (compareResult < 0)
                {
                    lesser.Add(element);
                }
                if (compareResult == 0)
                {
                    equal.Add(element);
                }
                if (compareResult > 0)
                {
                    greater.Add(element);
                }
                
            }

            List<Book> sortedLesser = Sort(lesser, bookComparer);
            List<Book> sortedGreater = Sort(greater, bookComparer);
            List<Book> sorted = new();

            sorted.AddRange(sortedLesser);
            sorted.AddRange(equal);
            sorted.AddRange(sortedGreater);

            return sorted;
        }


    }
}
