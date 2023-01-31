using System;
using GeometryCalc.Core;

namespace GeometryCalc.Calculator
{
    public class ShapeCalculator
    {
        public IShape Shape { get; set; }

        public double CalculateArea()
        {
            return Shape.CalculateArea();
        }

        public bool? IsRight()
        {
            ITriangle triangle = Shape as ITriangle;
            if (triangle == null)
            {
                return null;
            }
            return triangle.IsRight();
        }
    }
}
