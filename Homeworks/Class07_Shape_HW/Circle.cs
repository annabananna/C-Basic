namespace Models
{
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public Circle(string name, string color, int radius)  : base(name, color)
        {
            Radius = radius;
        }

        public override string getArea()
        {
            return (3.14 * (Radius * Radius)).ToString();
        }

        public override string getPerimeter()
        {
            return (2 * 3.14 * Radius).ToString();
        }
    }
}
