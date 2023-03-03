using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    public class Format2Decorator : OutputModuleDecorator
    {
        string AddSpecial()
        {
            return " || с форматом 2 || ";
        }
        public Format2Decorator(OutputModule decoratee) : base(decoratee)
        {

        }
        public override string ShowNews(Note note)
        {
            return AddSpecial() + decoratee.ShowNews(note) + AddSpecial(); 
        }
    }
}
