using Microsoft.VisualStudio.TestTools.UnitTesting;
using dotnet_figurasGeometricas_tests;

namespace FigurasGeometricasTests
{
    [TestClass]
    public class FigurasTests
    {
        [TestMethod]
        public void Triangulo_DeveRetornarValorCorreto()
        {
            //Arrange
            Triangulo tr = new Triangulo
            {
                @base = 5,
                altura = 3
            };

            //Act
            double area = tr.CalcularArea();

            //Assert
            Assert.AreEqual(7.5, area, "Area do triangulo não calculado corretamente");
        }

        [TestMethod]
        public void Quadrado_DeveRetornarValorCorreto()
        {
            //Arrange
            Quadrado q = new Quadrado
            {
                lado = 10
            };

            //Act
            double area = q.CalcularArea();

            //Assert
            Assert.AreEqual(100, area, "Area do Quadrado não calculado corretamente");
        }

        [TestMethod]
        public void Circunferencia_DeveRetornarValorCorreto()
        {
            //Arrange
            Circunferencia c = new Circunferencia
            {
                raio = 12
            };

            //Act
            string str = c.CalcularArea().ToString("F");
            double area = double.Parse(str);

            //Assert
            Assert.AreEqual(452.39, area, "Area do Circunferencia não calculado corretamente");
        }

        [TestMethod]
        public void Trapezio_DeveRetornarValorCorreto()
        {
            //Arrange
            Trapezio tp = new Trapezio
            {
                baseMaior = 10,
                baseMenor = 5,
                altura = 6
            };

            //Act
            double area = tp.CalcularArea();

            //Assert
            Assert.AreEqual(45, area, "Area do Trapezio não calculado corretamente");
        }
    }
}
