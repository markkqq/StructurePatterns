using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class TitleBookComparer : IBookComparer
    {
        public int Compare(Book firstBook, Book secondBook)
        {
            int minLength = Math.Min(firstBook.Title.Length, secondBook.Title.Length);
            for(int i = 0; i < minLength; i++)
            {
                if (firstBook.Title[i] - secondBook.Title[i] != 0)
                {
                    return firstBook.Title[i] - secondBook.Title[i];
                }
            }
            return 0;
        }
    }
}
