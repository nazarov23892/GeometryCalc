using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryCalc.Core
{
    public class Circle : IShape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius < 0.0D)
            {
                throw new ArgumentException($"Invalid radius value: {radius}");
            }
            Radius = radius;
        }

        public double CalculateArea()
        {
            double S = Math.PI * Radius * Radius;
            return S;
        }
    }
}
