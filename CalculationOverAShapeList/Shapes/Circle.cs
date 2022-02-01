using System;
using CalculationOverAShapeList.Constants;

namespace CalculationOverAShapeList.Shapes
{
    public class Circle : IShape
    {
        private readonly double _radius;
        public int Corners => 0;
        public Circle(double radius)
        {
            _radius = radius;
        }

        public double CalculateArea()
        {
            if (IsShapeValid())
            {
                var result = MathConstants.PiNumber * Math.Pow(_radius, 2);
                return result;
            }
            Console.WriteLine(this.GetType().Name + " is invalid, returning area = 0");
            return 0;
        }
        public bool IsShapeValid()
        {
            if (_radius <= 0)
            {
                return false;
            }

            return true;
        }
    }
}
