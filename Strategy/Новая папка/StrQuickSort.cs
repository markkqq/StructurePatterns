using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class StrQuickSort : SortingAlgorithm<string>
    {
        protected override int Compare(string firstItem, string secondItem)
        {

            int minLength = Math.Min(firstItem.Length, secondItem.Length);
            for(int i = 0; i < minLength; i++)
            {
                char firstItemSymbol = firstItem[i];
                char secondItemSymbol = secondItem[i];
                if (firstItemSymbol != secondItemSymbol)
                {
                    return firstItemSymbol - secondItemSymbol;
                }
            }
            return 0;
        }
    }
}
