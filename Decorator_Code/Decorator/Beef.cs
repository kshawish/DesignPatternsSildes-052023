using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Beef : SandwichDecorator
    {
        public Beef(ISandwich sandwich) : base(sandwich) { }

        public override double GetCost()
        {
            return base.GetCost() + 2;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Beef";
        }
    }
}
