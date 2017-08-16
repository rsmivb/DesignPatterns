using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Factory2.Factories
{
    public class BMW355XiFactory : IAutoFactory
    {
        public IAuto CreateAutomobile()
        {
            return new BMW335Xi();
        }
    }
}
