using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Models
{
    public class Shape
    {
        private string name;
        private string color;
        public static int[,] Position { get; set; }
       
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public Shape(string name, string color)
        {
            Name = name;
            Color = color;         
            Position = new int[1, 2] { { 0, 0 } }; // initial 0,0 position
          
        }

        public virtual string getArea()
        {
            return "There is no special implementation for area";
        }

        public virtual string getPerimeter()
        {
            return "There is no special implementation for area";
        }

        public static void Move()
        {

            Position[0, 0] += 5;
            Position[0, 1] += 5;

        }

    }
}