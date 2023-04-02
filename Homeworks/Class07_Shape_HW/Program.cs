using System.Reflection.Metadata;
using System.Security.Authentication;
using Models;

namespace Homework_Class07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectan = new Rectangle("rec", "blue", 3, 4);
            //rectan.SideA = 3;
            //rectan.SideB = 4;
            rectan.Name = "recangle1";
            rectan.Color = "red";
            Console.WriteLine($"The name of rectangle is {rectan.Name} and it's color is {rectan.Color}");
            Console.WriteLine($"--> The area of the {rectan.Name} is : {rectan.getArea()}");
            Console.WriteLine($"--> The perimeter of the {rectan.Name} is : {rectan.getPerimeter()}");

            Rectangle.Move();
            Console.WriteLine($"--> The new position of {rectan.Name} is x: {Rectangle.Position[0,0]} and y: {Rectangle.Position[0,1]}");

            Circle circle = new Circle("cir", "red", 5);
            circle.Name = "circle1";
            circle.Color = "blue";
            Console.WriteLine($"The name of the circle is: {circle.Name} and it's color is: {circle.Color}");
            Console.WriteLine($"--> The area of the {circle.Name} is : {circle.getArea()}");
            Console.WriteLine($"--> The perimeter of the {circle.Name} is : {circle.getPerimeter()}");

            Circle circle2 = new Circle("cir2", "yellow", 8);
            Console.WriteLine($"--> The area of the {circle2.Name} is : {circle2.getArea()}");
            Console.WriteLine($"--> The perimeter of the {circle2.Name} is : {circle2.getPerimeter()}");

            Circle.Move();
            Console.WriteLine($"--> The new position of the circle is x: {Circle.Position[0, 0]} and y: {Circle.Position[0, 1]}");

        }
    }
}