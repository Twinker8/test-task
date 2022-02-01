using System;

namespace CalculationOverAShapeList.Shapes
{
    public class Triangle : IShape
    {
        private readonly double _height;
        private readonly double _baseLength;
        public int Corners => IsShapeValid() ? 3 : 0;
        public Triangle(double height, double baseLength)
        {
            _height = height;
            _baseLength = baseLength;
        }

        public double CalculateArea()
        {
            if (IsShapeValid())
            {
                double result = (_height * _baseLength) / 2;
                return result;
            }
            Console.WriteLine(this.GetType().Name + " is invalid, returning area = 0");
            return 0;
        }

        public bool IsShapeValid()
        {
            if (_height <= 0 || _baseLength <= 0)
            {
                return false;
            }

            return true;
        }
    }
}
