namespace QuadraticEquationSolver;

/// <summary>
/// La classe QuadraticSolver fournit des méthodes pour résoudre les équations du second degré.
/// </summary>
public class QuadraticSolver
{
    /// <summary>
    /// Résout l'équation du second degré tel que ax² + bx + c = 0.
    /// </summary>
    /// <param name="a">Le coefficient de x².</param>
    /// <param name="b">Le coefficient de x.</param>
    /// <param name="c">Le terme constant.</param>
    /// <returns>Les valeurs de x qui résolvent l'équation, ou null si aucune solution réelle n'existe.</returns>
    /// <exception cref="ArgumentException">Si le coefficient a est zéro.</exception>
    public (double? x1, double? x2) Solve(double a, double b, double c)
    {
        if (a == 0)
        {
            throw new ArgumentException("Le coefficient 'A' ne peut pas être zéro pour une équation du second degré.");
        }

        double discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            // Deux solutions possibles, calcule de x1 et de x2
            double sqrtDiscriminant = Math.Sqrt(discriminant);
            double x1 = (-b - sqrtDiscriminant) / (2 * a);
            double x2 = (-b + sqrtDiscriminant) / (2 * a);
            return (x1, x2);
        }
        else if (discriminant == 0)
        {
            // Une solution possible, calcul de x
            double x = -b / (2 * a);
            return (x, null);
        }
        else
        {
            // Aucune solution possible
            return (null, null);
        }
    }
}