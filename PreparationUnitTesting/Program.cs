using QuadraticEquationSolver;

QuadraticSolver solver = new QuadraticSolver();

var result = solver.Solve(2, -1, -6);

Console.WriteLine($"x1: {result.x1} - x2: {result.x2}");

if (result.x1 == null && result.x2 == null) {
    Console.WriteLine($"Aucune solution");
}