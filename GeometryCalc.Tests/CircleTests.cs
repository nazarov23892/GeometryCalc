using System;
using Xunit;
using GeometryCalc.Core;

namespace GeometryCalc.Tests
{
    public class CircleTests
    {
        [Fact]
        public void CalcAreaTest()
        {
            // arrange
            double R = 5D;
            var circle = new Circle(R);
            var value = Math.PI * R * R;

            //act
            var result = circle.CalculateArea(); ;

            //assert
            Assert.Equal(value, result);
        }

        [Fact]
        public void CalcAreaTestWhenRadiusZero()
        {
            // arrange
            double R = 0D;
            var circle = new Circle(R);

            //act
            var result = circle.CalculateArea(); ;

            //assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void PassingNegativeRadiusTest()
        {
            // arrange
            double R = -1D;
            
            //assert
            Assert.Throws<ArgumentException>(() => new Circle(R));
        }
    }
}
