using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_Polymorphism
{
    public abstract class Shape
    {
        public virtual string Draw()
        {
            return "Drawing shape";
        }

        public abstract string Area();

    }
}