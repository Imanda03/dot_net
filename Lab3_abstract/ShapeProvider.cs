using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_abstract
{
    public class ShapeProvider
    {
        public Shape GetShape(String shapeType)
        {
            switch(shapeType)
            {
                case "circle":
                    return new Circle(4);
                case "rectangle":
                    return new Rectangle(5, 5);
                default:
                    return new Circle(4);
                    break;
            }
        }
    }
}
