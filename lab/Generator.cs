using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    public class Generator
    {
        public virtual Note GenerateNote()
        {
            return new Note("без названия","неизвестен");
        }
    }
}
