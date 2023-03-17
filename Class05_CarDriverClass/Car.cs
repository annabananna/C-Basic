using System.Net.Security;

namespace Class05_Task2HW
{
    internal class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver1 { get; set; }  

        public Car(string model, int speed, Driver driver1)
        {
            Model = model;
            Speed = speed;
            Driver1 = driver1;
        }

        public int CalculateSpeed(Driver Driver1)
        {
            return Driver1.Level*Speed;
        }
    }
}
