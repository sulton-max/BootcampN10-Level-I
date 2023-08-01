namespace N17.SealedClass
{
    internal sealed class Circle : Shape
    {
        public int Radius { get; set; }

        public Circle(int radius)
        {
            Radius = radius;
        }

        public override int CalculateArea()
        {
            return (int)(Math.PI * Math.Pow(Radius, 2));
        }
    }

    // invalid
    //public class UltimateCircle : Circle
    //{

    //}
}
