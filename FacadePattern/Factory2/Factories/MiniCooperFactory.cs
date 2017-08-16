﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Factory2.Factories
{
    public class MiniCooperFactory : IAutoFactory
    {
        public IAuto CreateAutomobile()
        {
            return new MiniCooper();
        }
    }
}
