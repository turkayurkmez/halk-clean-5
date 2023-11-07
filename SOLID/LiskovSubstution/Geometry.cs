namespace LiskovSubstution
{
    public class Geometry
    {
        public IArea GetShape(int unit1, int? unit2 = null)
        {
            if (unit2.HasValue)
            {
                return new Rectangle() { Width = unit1, Height = unit2.Value };
            }
            return new Square() { Edge = unit1 };
        }
    }

    public interface IArea
    {
        int GetArea();
    }

    public class Rectangle : IArea
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public int GetArea() => Width * Height;
    }
    public class Square : IArea
    {
        public int Edge { get; set; }

        public int GetArea()
        {
            return Edge * Edge;
        }
    }

}
