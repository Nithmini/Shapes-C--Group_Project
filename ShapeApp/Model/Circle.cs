using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApp.Model
{
    internal class Circle:Shape
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
            shapeType = "Circle";
        }
        public override double calculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
