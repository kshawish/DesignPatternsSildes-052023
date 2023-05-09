using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Design_Pattern.Classes
{
    class Rectangle : Shape
    {
        private int width;
        private int height;
        public Rectangle() { }
        public Rectangle(Rectangle source) : base(source)
        {
            this.width = source.width;
            this.height = source.height;
            
        }
        public void LoadData()
        {
            this.width = 5;
            this.height = 6;
        }
        public void SetWidth(int width)
        {
            this.width = width;
        }
        public int GetWidth()
        {
            return this.width;
        }
        public void SetHeight(int height)
        {
            this.height = height;
        }
        public int GetHeight()
        {
            return this.height;
        }
        public override Shape Clone() => new Rectangle(this);

    }
}
