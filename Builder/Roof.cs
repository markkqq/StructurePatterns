using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Roof
    {
        public string Material { get; } = "glass";
        public Roof(string material)
        {
            Material = material;
        }
    }
}
