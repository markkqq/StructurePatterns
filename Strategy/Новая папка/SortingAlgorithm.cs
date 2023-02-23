using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    abstract class SortingAlgorithm<T>
    {
        public List<T> Sort(List<T> unsorted)
        {
            if (unsorted.Count == 0 | unsorted.Count == 1)
            {
                return unsorted;
            }

            List<T> lesser = new();
            List<T> equal = new();
            List<T> greater = new();

            T baseElement = unsorted[0];

            foreach(T element in unsorted)
            {
                int compareResult = Compare(baseElement,element);
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

            List<T> sortedLesser = Sort(lesser);
            List<T> sortedGreater = Sort(greater);
            List<T> sorted = new();

            sorted.AddRange(sortedLesser);
            sorted.AddRange(equal);
            sorted.AddRange(sortedGreater);

            return sorted;
        }
        protected abstract int Compare(T firstItem, T secondItem);

    }
}
