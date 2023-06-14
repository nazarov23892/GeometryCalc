using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryCalc.Core
{
    public class Triangle : IShape, ITriangle
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0D 
                || b <= 0D
                || c <= 0D)
            {
                throw new ArgumentException($"Invalid side value: a:{a}; b:{b}; c:{c}");
            }
            if (a >= b + c
                || b >= c + a
                || c >= a + b)
            {
                throw new ArgumentException($"Sides do not specify a triangle: a:{a}; b:{b}; c:{c}");
            }
            SideA = a;
            SideB = b;
            SideC = c;
        }

        public double CalculateArea()
        {
            // Heron's formula  
            double semiperimeter = (SideA + SideB + SideC) / 2D;
            double area = Math.Sqrt(semiperimeter * (semiperimeter - SideA) * (semiperimeter - SideB) * (semiperimeter - SideC));
            return area;
        }

        public bool IsRight()
        {
            double A2 = SideA * SideA;
            double B2 = SideB * SideB;
            double C2 = SideC * SideC;

            // Pythagorean theorem 
            return A2 == B2 + C2
                || B2 == C2 + A2
                || C2 == A2 + B2;
        }
    }
}
