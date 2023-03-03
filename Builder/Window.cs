using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Window
    {
        public Window(int windowsCount)
        {
            Count = windowsCount;
        }

        public int Count { get; } = 0;
    }
}
