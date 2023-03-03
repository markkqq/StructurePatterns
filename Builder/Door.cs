using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Door
    {
        public string Material { get; } = "glass";
        public int Count { get; } = 0;
        public Door(int count,string material)
        {
            Count = count;
            Material = material;
        }
    }
}
