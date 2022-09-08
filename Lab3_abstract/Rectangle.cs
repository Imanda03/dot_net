using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_abstract
{
    internal class Rectangle: Shape
    {
        int l, b;
        public Rectangle(int length, int breath)
        {
            l = length;
            b = breath;
        }
        public override int Area()
        {
            return l * b;
        }
    }
}
