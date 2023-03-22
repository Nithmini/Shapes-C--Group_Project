using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApp.Model
{
    public class Square:Shape
    {
        public double side;
        public Square(double side)
        {
            this.side = side;
            shapeType = "Square";
        }
        public override double calculatePerimeter()
        {
            return 4 * side;
        }
    }
}
