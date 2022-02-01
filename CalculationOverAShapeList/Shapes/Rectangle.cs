using System;

namespace CalculationOverAShapeList.Shapes
{
    public class Rectangle : IShape
    {
        private readonly double _height;
        private readonly double _width;

        public int Corners => IsShapeValid() ? 4 : 0; 
        public Rectangle(double height, double width)
        {
            _height = height;
            _width = width;
        }

        public double CalculateArea()
        {
            if (IsShapeValid())
            {
                var result = _height * _width;
                return result;
            }
            Console.WriteLine(this.GetType().Name + " is invalid, returning area = 0");
            return 0;
        }

        public bool IsShapeValid()
        {
            if (_height <= 0 || _width <= 0)
            {
                return false;
            }

            return true;
        }
    }
}
