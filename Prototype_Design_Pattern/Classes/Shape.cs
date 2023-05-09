using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Design_Pattern.Classes
{
    abstract class Shape
    {
        private int x;
        private int y;
        public Shape()
        {

        }
        public Shape(Shape source) : base()
        {

            this.x = source.x;
            this.y = source.y;
        }

        public abstract Shape Clone();

    }
}
