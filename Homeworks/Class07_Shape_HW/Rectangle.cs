namespace Models
{
    public class Rectangle : Shape
    {
        public int SideA { get; set; }
        public int SideB { get; set; }

        public Rectangle(string name, string color, int sideA, int sideB) : base(name, color)
        {
            SideA = sideA;
            SideB = sideB;
        }

        public override string getArea()
        {
            return (SideA * SideB).ToString();
        }

        public override string getPerimeter()
        {
            return ((2 * SideA) + (2 * SideB)).ToString();
        }

    }
}
