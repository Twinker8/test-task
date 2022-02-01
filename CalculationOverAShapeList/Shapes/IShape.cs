namespace CalculationOverAShapeList.Shapes
{
     public interface IShape
    {
        public double CalculateArea();

        public bool IsShapeValid();

        public int Corners { get; }
    }
    
        
    
}
