using System;
using JetBrains.Annotations;
using QuadraticEquationSolver;
using Xunit;

namespace QuadraticEquationSolver.Tests;

[TestSubject(typeof(QuadraticSolver))]
public class QuadraticSolverTest
{
    [Fact]
    public void Solve_ShouldReturnTwoDistinctRealRoots_WhenDiscriminantIsPositive()
    {
        // Arrange (Préparer le test)
        var solver = new QuadraticSolver();
        double a = 2;
        double b = -1;
        double c = -6;

        // Act (Appeler la fonctionnalité)
        var result = solver.Solve(a, b, c);

        // Assert (Tester le résultat obtenu)
        var expected = (x1: -(3 / 2.0), x2: 2.0);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Solve_ShouldReturnOneRealRoot_WhenDiscriminantIsZero()
    {
        // Arrange
        var solver = new QuadraticSolver();
        double a = 2;
        double b = -3;
        double c = 9 / 8.0;

        // Act
        var result = solver.Solve(a, b, c);

        // Assert
        (double x1, double? x2) expected = (x1: 3 / 4.0, x2: null);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(1, 3, 10)]
    [InlineData(1, 0, 1)]
    public void Solve_ShouldReturnNoRealRoots_WhenDiscriminantIsNegative(double a, double b, double c)
    {
        // Arrange
        var solver = new QuadraticSolver();

        // Act
        var result = solver.Solve(a, b, c);

        // Assert
        (double? x1, double? x2) expected = (x1: null, x2: null);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(0, 1, 1)]
    public void Solve_ShouldThrowArgumentException_WhenACoefficientIsZero(double a, double b, double c)
    {
        // Arrange
        var solver = new QuadraticSolver();
        
        // Act & Assert
        Assert.Throws<ArgumentException>(() => solver.Solve(a, b, c));
    }
}