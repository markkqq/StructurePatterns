using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class IntQuickSort : SortingAlgorithm<int>
    {
        protected override int Compare(int firstItem, int secondItem)
        {
            return firstItem-secondItem;
        }
    }
}
