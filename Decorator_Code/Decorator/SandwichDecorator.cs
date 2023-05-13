using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class SandwichDecorator : ISandwich
    {
        private ISandwich sandwich;

        public SandwichDecorator(ISandwich sandwich)
        {
            this.sandwich = sandwich;
        }

        public virtual double GetCost()
        {
            return this.sandwich.GetCost();
        }

        public virtual string GetDescription()
        {
            return this.sandwich.GetDescription();
        }
    }
}
