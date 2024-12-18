using NUnit.Framework;
using ConsoleApp1; // Assurez-vous que le namespace correspond � votre projet

namespace ConsoleApp1.Tests
{
    [TestFixture]
    public class SolutionTests
    {
        [Test]
        public void Discriminant_Positive_TwoSolutions()
        {
            // Arrange
            double a = 1;
            double b = -3;
            double c = 2; // Discriminant = 1 (positif)
            Solution equation = new Solution(a, b, c);

            // Act
            var result = equation.Resolve();

            // Assert
            Assert.IsNull(result, "La m�thode doit renvoyer null pour indiquer que nous avons deux solutions r�elles.");
            // On peut aussi v�rifier les solutions avec les valeurs de x1 et x2 si besoin
            // Assert.AreEqual(2, result.X1);
            // Assert.AreEqual(1, result.X2);
        }

        [Test]
        public void Discriminant_Zero_OneSolution()
        {
            // Arrange
            double a = 1;
            double b = -2;
            double c = 1; // Discriminant = 0
            Solution equation = new Solution(a, b, c);

            // Act
            var result = equation.Resolve();

            // Assert
            Assert.AreEqual(1, result, "La solution devrait �tre x = 1.");
        }

        [Test]
        public void Discriminant_Negative_NoSolutions()
        {
            // Arrange
            double a = 1;
            double b = 2;
            double c = 5; // Discriminant = -16 (n�gatif)
            Solution equation = new Solution(a, b, c);

            // Act
            var result = equation.Resolve();

            // Assert
            Assert.IsNull(result, "L'�quation ne devrait pas avoir de solution r�elle.");
        }
    }
}
