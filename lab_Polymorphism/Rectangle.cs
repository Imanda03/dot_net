using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_Polymorphism
{
    public class Rectangle : Shape
    {
        public override string Draw()
        {
            return "Drawing rectangle";
        }

        public override  string Area()
        {
            return "I am Rectangle area";
        }
    }
}
