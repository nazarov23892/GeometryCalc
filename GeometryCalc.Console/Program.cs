using System;
using GeometryCalc.Core;
using GeometryCalc.Calculator;

namespace GeometryCalc.Console
{

    class CustomRectangle : IShape
    {
        public double SideA { get;  }
        public double SideB { get;  }

        public CustomRectangle(double a, double b)
        {
            SideA = a;
            SideB = b;
        }

        public double CalculateArea()
        {
            return SideA * SideB;
        }
    }

    class Program
    {
        static void print(double area, bool? isRight)
        {
            System.Console.WriteLine($"S={area}");
            if (isRight.HasValue)
            {
                System.Console.WriteLine($"IsRight={isRight}");
            }
            System.Console.WriteLine("---");
        }

        static void Demo_1()
        {
            // use directly 

            IShape shape;
            double area;
            bool? isRight;

            shape = new Circle(8);
            area = shape.CalculateArea();
            isRight = (shape as ITriangle)?.IsRight();
            print(area, isRight);

           
            shape = new Triangle(7, 7, 7);
            area = shape.CalculateArea();
            isRight = (shape as ITriangle)?.IsRight();
            print(area, isRight);
        }

        static void Demo_2()
        {
            ShapeCalculator calculator = new ShapeCalculator();
            
            double Area;
            bool? isRight;

            calculator.Shape = new Triangle(a: 3, b: 4, c: 5);
            Area = calculator.CalculateArea();
            isRight = calculator.IsRight();
            print(Area, isRight);

            calculator.Shape = new Circle(radius: 3);
            Area = calculator.CalculateArea();
            isRight = calculator.IsRight();
            print(Area, isRight);

            calculator.Shape = new CustomRectangle(a: 4, b: 5);
            Area = calculator.CalculateArea();
            isRight = calculator.IsRight();
            print(Area, isRight);
        }

        static void Main(string[] args)
        {
            Demo_1();
            Demo_2();
        }
    }
}
