using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Design_Pattern.Classes
{
    
    class Circle : Shape
    {
        public int ridius;
        public Circle() { }
        public Circle(Circle source) : base(source)
        {
            this.ridius = source.ridius;
        }
        public override Shape Clone() => new Circle(this);

    }
    /*
    class Circle : ICloneable
    {
        public int ridius;
        public Circle() { }

        public Circle(Circle source)
        {
            this.ridius = source.ridius;
        }
        public object Clone() => new Circle(this);
    }
    */
 

}
