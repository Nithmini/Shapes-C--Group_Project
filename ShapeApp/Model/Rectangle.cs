using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApp.Model
{
    internal class Rectangle:Shape
    {
        private double length;
        private double breadth;

        public Rectangle(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
            shapeType = "Rectangle";
        }

        override public double calculatePerimeter() {
            return 2 * (length + breadth);
        }
    }
}
