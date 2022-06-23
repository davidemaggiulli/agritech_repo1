using System;
using Xunit;
using MathLib;

namespace MathLib.Test
{
    public class EquationTests
    {
        [Fact]
        public void EquationShouldReturnTwoDifferentSolutionsTest()
        {
            //Arrange
            Equation equation = new Equation();

            //Act
            double[] solutions = equation.ResolveSecondDegreeEquation(1.0, -3.0, 2.0);

            //Assert
            Assert.NotNull(solutions);
            Assert.Equal(2, solutions.Length);
            Assert.Equal(1, solutions[0]);
            Assert.Equal(2, solutions[1]);
        }

        [Fact]
        public void EquationShouldReturnTwoDifferentSolutionsTest2()
        {
            //Arrange
            Equation equation = new Equation();

            //Act
            double[] solutions = equation.ResolveSecondDegreeEquation(1.0, -5.0, 6.0);

            //Assert
            Assert.NotNull(solutions);
            Assert.Equal(2, solutions.Length);
            Assert.Equal(2, solutions[0]);
            Assert.Equal(3, solutions[1]);
        }

        [Fact]
        public void EquationSholudReturnOneSolutionTest()
        {
            //Arrange
            Equation equation = new Equation();

            //Act
            double[] solutions = equation.ResolveSecondDegreeEquation(1, 2, 1);

            //Assert
            Assert.NotNull(solutions);
            Assert.Single(solutions);
            Assert.Equal(-1, solutions[0]);
        }

        [Fact]
        public void EquationShouldReturnZeroSolutionsTest()
        {
            //Arrange
            Equation equation = new Equation();

            //Act
            double[] solutions = equation.ResolveSecondDegreeEquation(1, -3, 10);

            //Assert
            Assert.Null(solutions);
        }
    }
}
