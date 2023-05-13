using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Executor
    {
        public static void Main(string[] args)
        {
            ISandwich basicSandwich = new Beef(new Cheese(new BasicSandwich()));
            Console.WriteLine("Description = " + basicSandwich.GetDescription());
            Console.WriteLine("Cost = " + basicSandwich.GetCost());
        }
    }
}
