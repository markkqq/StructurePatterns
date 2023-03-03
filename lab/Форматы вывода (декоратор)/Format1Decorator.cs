using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    public class Format1Decorator : OutputModuleDecorator
    {
        string AddSpecial()
        {
            return " -- с форматом 1 -- "; 
        }
        public Format1Decorator(OutputModule decoratee) : base(decoratee)
        {

        }
        public override string ShowNews(Note note)
        {
            return AddSpecial()+decoratee.ShowNews(note)+AddSpecial();
        }
    }
}
