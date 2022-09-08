using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_abstract
{
    public class Circle: Shape
    {
        int r;
        public Circle(int radius)
        {
            r = radius;
        }
        public override int Area()
        {
            return 3*r*r;
        }
    }
}
