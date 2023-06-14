using System;
using Xunit;
using GeometryCalc.Core;

namespace GeometryCalc.Tests
{
    public class CircleTests
    {
        [Fact]
        public void CanCalculateArea()
        {
            // arrange
            double R = 5D;
            var circle = new Circle(R);
            var value = Math.PI * R * R;

            //act
            var result = circle.CalculateArea(); ;

            //assert
            Assert.Equal(
                expected: value, 
                actual: result);
        }

        [Fact]
        public void CanCalculateArea_WhenRadiusZero()
        {
            // arrange
            double R = 0D;
            var circle = new Circle(R);

            //act
            var result = circle.CalculateArea(); ;

            //assert
            Assert.Equal(
                expected: 0,
                actual: result);
        }

        [Fact]
        public void CannotCreate_WhenNegativeRadius()
        {
            // arrange
            double R = -1D;
            
            //assert
            Assert.Throws<ArgumentException>(() => new Circle(R));
        }
    }
}
