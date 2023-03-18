using System.Net.Security;

namespace Class05_Task2HW
{
    internal class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver1 { get; set; }  

        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }

        public int CalculateSpeed()
        {
            return Driver1.Level*Speed;
        }
    }
}
