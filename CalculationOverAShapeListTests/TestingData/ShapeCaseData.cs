using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculationOverAShapeList.Shapes;

namespace CalculationOverAShapeListTests.TestingData
{
    public class ShapeCaseData
    {
        public List<IShape> ListOfShapes { get; }

        public double AreaCalculationExpectedResult { get; }

        public int CornerCalculationExpectedResult { get; }

        public ShapeCaseData(List<IShape> listOfShapes, int cornerCalculationExpectedResult, double areaCalculationExpectedResult)
        {
            CornerCalculationExpectedResult = cornerCalculationExpectedResult;
            AreaCalculationExpectedResult = areaCalculationExpectedResult;
            ListOfShapes = listOfShapes;
        }
    }
}
