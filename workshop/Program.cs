using System;

namespace workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            //simple factory
            var geometryType = EGeometries.Circle;
            var calculator = SimpleFactory.CreateCalculator(geometryType);
            //factory method
            var calculatorFactory = new FactoryMethod.RectangleCalculatorFactory();
            var rectangleCalculator = calculatorFactory.CreateAreaCalculator();
        }
    }
}
