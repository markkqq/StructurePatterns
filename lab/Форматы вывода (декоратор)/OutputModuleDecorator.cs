using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    public abstract class OutputModuleDecorator : OutputModule
    {
        protected readonly OutputModule decoratee;
        public OutputModuleDecorator(OutputModule decoratee)
        {
            this.decoratee = decoratee ?? throw new ArgumentNullException(nameof(decoratee));
        }
    }
}
