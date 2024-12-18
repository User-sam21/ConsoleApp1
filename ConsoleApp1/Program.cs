using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entrée des coefficients
            Console.WriteLine("Résolution d'une équation de degré 2 (ax^2 + bx + c = 0)");

            Console.Write("Entrez la valeur de a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Entrez la valeur de b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Entrez la valeur de c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            // Création de l'objet Solution et résolution
            Solution equation = new Solution(a, b, c);
            equation.Resolve();
        }
    }
}
