using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    public class OutputModule
    {
        public virtual string ShowNews(Note note)
        {
            return note.Content;
        }
    }
}
