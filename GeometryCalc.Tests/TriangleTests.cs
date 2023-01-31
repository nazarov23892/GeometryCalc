using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using GeometryCalc.Core;

namespace GeometryCalc.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void InvalidSideA_Test()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a: 0, b: 4, c: 5));
            Assert.Throws<ArgumentException>(() => new Triangle(a:-1, b: 4, c: 5));
        }

        [Fact]
        public void InvalidSideB_Test()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a: 3, b: 0, c: 5));
            Assert.Throws<ArgumentException>(() => new Triangle(a: 3, b: -1, c: 5));
        }

        [Fact]
        public void InvalidSideC_Test()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a: 3, b: 4, c: 0));
            Assert.Throws<ArgumentException>(() => new Triangle(a: 3, b: 4, c: -1));
        }

        [Fact]
        public void SidesValuesIsNotTriangle_Test()
        {
            // a == b + c
            Assert.Throws<ArgumentException>(() => new Triangle(a: 3, b: 2, c: 1));

            // a > b + c
            Assert.Throws<ArgumentException>(() => new Triangle(a: 4, b: 2, c: 1));

            // b == c + a
            Assert.Throws<ArgumentException>(() => new Triangle(a: 2, b: 3, c: 1));

            // b > c + a
            Assert.Throws<ArgumentException>(() => new Triangle(a: 2, b: 4, c: 1));

            // c == a + b
            Assert.Throws<ArgumentException>(() => new Triangle(a: 2, b: 1, c: 3));

            // c > a + b
            Assert.Throws<ArgumentException>(() => new Triangle(a: 2, b: 1, c: 4));
        }

        [Fact]
        public void CalcAreaTest()
        {
            //arrange
            var value = 6D;
            var triangle = new Triangle(a: 3, b: 4, c: 5);

            //act
            var result = triangle.CalculateArea();

            //assert
            Assert.Equal(value, result);
        }

        [Fact]
        public void CheckTriangleIsRightTest()
        {
            //arrange
            var right = new Triangle(a: 3, b: 4, c: 5);
            var equilateral = new Triangle(a: 3, b: 3, c: 3);

            //act
            var result1 = right.IsRight();
            var result2 = equilateral.IsRight();

            //assert
            Assert.True(result1);
            Assert.False(result2);
        }
    }
}
