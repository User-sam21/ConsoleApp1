using System;

namespace ConsoleApp1
{
    public class Solution
    {
        // Propriétés pour stocker les coefficients
        private double A { get; set; }
        private double B { get; set; }
        private double C { get; set; }

        // Constructeur
        public Solution(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        // Méthode pour résoudre l'équation ax^2 + bx + c = 0
        public double? Resolve()
        {
            // Calcul du discriminant
            double discriminant = Math.Pow(B, 2) - 4 * A * C;

            if (discriminant > 0)
            {
                // Deux solutions réelles
                double x1 = (-B + Math.Sqrt(discriminant)) / (2 * A);
                double x2 = (-B - Math.Sqrt(discriminant)) / (2 * A);
                Console.WriteLine($"Les solutions sont : x1 = {x1} et x2 = {x2}");
                return null; // Pas de préférence sur la solution
            }
            else if (discriminant == 0)
            {
                // Une solution réelle unique
                double x = -B / (2 * A);
                Console.WriteLine($"La solution est : x = {x}");
                return x;
            }
            else
            {
                // Pas de solution réelle
                Console.WriteLine("L'équation n'a pas de solution réelle.");
                return null;
            }
        }
    }
}

