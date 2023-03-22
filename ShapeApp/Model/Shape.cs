using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApp.Model
{
    public abstract class Shape
    {
        public string shapeType;
        public abstract double calculatePerimeter();
    }
}
