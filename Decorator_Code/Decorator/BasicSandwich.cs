using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class BasicSandwich : ISandwich
    {
        public double GetCost()
        {
            return 10;
        }

        public string GetDescription()
        {
            return "Bread";
        }
    }
}
