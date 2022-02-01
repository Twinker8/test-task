using System.Collections.Generic;
using CalculationOverAShapeList.Calculator;
using CalculationOverAShapeList.Shapes;
using CalculationOverAShapeListTests.TestingData;
using NUnit.Framework;

namespace CalculationOverAShapeListTests.TestFixture
{
    [TestFixture]
    public class CalculationTests
    {
        [TestCaseSource(nameof(ShapeCases))]
        public void CalculateAreaSum(ShapeCaseData data)
        {
            ShapesCalculator calculator = new ShapesCalculator();

            double actual = calculator.CalculateAreasSum(data.ListOfShapes);

            Assert.AreEqual(data.AreaCalculationExpectedResult,actual);
        }

        [TestCaseSource(nameof(ShapeCases))]
        public void CalculateCornersSum(ShapeCaseData data)
        {
            ShapesCalculator calculator = new ShapesCalculator();

            double actual = calculator.CalculateCornersSum(data.ListOfShapes);

            Assert.AreEqual(data.CornerCalculationExpectedResult, actual);
        }

        private static IEnumerable<ShapeCaseData> ShapeCases()
        {
            yield return new ShapeCaseData(new List<IShape>
            {
                new Rectangle(2, 4),
                new Square(2),
                new Triangle(2, 3),
                new Circle(3)
            }, 11, 43.273499999999999);
            yield return new ShapeCaseData(new List<IShape>
            {
                new Rectangle(0,2),
                new Square(3),
                new Triangle(2,4.5),
                new Circle(2)
            }, 7, 26.066000000000003);
            yield return new ShapeCaseData(new List<IShape>
            {
                new Rectangle(2,5),
                new Square(-1),
                new Triangle(2,4.5),
                new Circle(2)
            }, 7, 27.066000000000003);
            yield return new ShapeCaseData(new List<IShape>
            {
                new Rectangle(2,5),
                new Square(3),
                new Triangle(2,-4.5),
                new Circle(2)
            }, 8, 31.566000000000003);
            yield return new ShapeCaseData(new List<IShape>
            {
                new Rectangle(2,5),
                new Square(3),
                new Triangle(2,4.5),
                new Circle(-2)
            }, 11, 23.5);

        }
    }
}