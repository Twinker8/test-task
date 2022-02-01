using System.Collections.Generic;
using System.Linq;
using CalculationOverAShapeList.Shapes;

namespace CalculationOverAShapeList.Calculator
{
    public class ShapesCalculator
    {
        public double CalculateAreasSum(List<IShape> listOfShapes)
        {
            return listOfShapes.Sum(s => s.CalculateArea());
        }
        public double CalculateCornersSum(List<IShape> listOfShapes)
        {
            return listOfShapes.Sum(s => s.Corners);
        }


    }
}
