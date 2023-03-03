using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Wall
    {
        public Wall(int count)
        {
            Count = count;
        }

        public int Count { get; } = 0;
    }
}
