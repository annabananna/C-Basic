using System.Reflection.Emit;
using System.Xml.Linq;

namespace Class05_Task2HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //make a class driver. add properties: name, level
            //make a class car. add properties: model, speed and driver
            //make a method of the car class called : calculatespeed() that takes a driver object
            //and calculates the skill multiplied by the speed of the car and return it as a result.
            //make a method racecars() that will get two car objects that will determine which car will win and print the result in the console.
            //make 4 car objects and 4 driver objects.
            //ask the user to select a two cars and two drivers for the cars. 
            //add the drivers to the cars and call the racecars() methods

            Driver d1 = new Driver("Bob", 2);
            Driver d2 = new Driver("Greg", 3);
            Driver d3 = new Driver("Jill", 4);
            Driver d4 = new Driver("Anne", 2);

            Car c1 = new Car("Hyndai", 150, d1);   //tuka ne bi trebalo manuelno da go dodadam d1
            Car c2 = new Car("Mazda", 200, d2);
            Car c3 = new Car("Ferrari", 280, d3);
            Car c4 = new Car("Porshe", 250, d4);


            //Console.WriteLine(RaceCars(c1, c2));
            while (true)
            {
                Console.WriteLine("Please enter Y for racing");
                string output = Console.ReadLine();
                if (output.ToUpper() == "Y")
                {
                    Console.WriteLine("Please select first car for racing from the following options: 1, 2, 3, or 4");
                    while (true)
                    {
                        string option1 = Console.ReadLine();
                        Car choosenCar1 = null;
                        Car choosenCar2 = null;
                        if (option1 != "1" && option1 != "2" && option1 != "3" && option1 != "4")
                        {
                            Console.WriteLine("You have entered a wrong option, please select car from 1-4");
                            continue;
                        }
                        else
                        {
                            switch (option1)
                            {
                                case "1":
                                    choosenCar1 = c1;
                                    break;
                                case "2":
                                    choosenCar1 = c2;
                                    break;
                                case "3":
                                    choosenCar1 = c3;
                                    break;
                                case "4":
                                    choosenCar1 = c4;
                                    break;
                            }
                        }
                        Console.WriteLine("Please select second car for racing!");
                        while (true)
                        {
                            string option2 = Console.ReadLine();
                            if ((option2 == option1) || (option2 != "1" && option2 != "2" && option2 != "3" && option2 != "4"))
                            {
                                Console.WriteLine("You have choosen not valid option or same car as previous time! Please select valid option.");
                                continue;
                                ;
                            }
                            else
                            {
                                switch (option2)
                                {
                                    case "1":
                                        choosenCar2 = c1;
                                        break;
                                    case "2":
                                        choosenCar2 = c2;
                                        break;
                                    case "3":
                                        choosenCar2 = c3;
                                        break;
                                    case "4":
                                        choosenCar2 = c4;
                                        break;
                                }
                            }
                            Console.WriteLine("Please select first driver for racing from the following options: 1, 2, 3, or 4");
                            Driver choosenDriver1 = null;
                            Driver choosenDriver2 = null;
                            while (true)
                            {
                                string firstDriver = Console.ReadLine();
                                if (firstDriver != "1" && firstDriver != "2" && firstDriver != "3" && firstDriver != "4")
                                {
                                    Console.WriteLine("You have entered a wrong option, please select driver from 1-4");
                                    continue;
                                }
                                else
                                {
                                    switch (firstDriver)
                                    {
                                        case "1":
                                            choosenDriver1 = d1;
                                            break;
                                        case "2":
                                            choosenDriver1 = d2;
                                            break;
                                        case "3":
                                            choosenDriver1 = d3;
                                            break;
                                        case "4":
                                            choosenDriver1 = d4;
                                            break;
                                    }
                                }
                                Console.WriteLine("Please select second driver for racing!");
                                while (true)
                                {
                                    string secondDriver = Console.ReadLine();
                                    if ((secondDriver == firstDriver) || (secondDriver != "1" && secondDriver != "2" && secondDriver != "3" && secondDriver != "4"))
                                    {
                                        Console.WriteLine("You have choosen not valid option or same car as previous time! Please select valid option.");
                                        continue;
                                        ;
                                    }
                                    else
                                    {
                                        switch (secondDriver)
                                        {
                                            case "1":
                                                choosenDriver2 = d1;
                                                break;
                                            case "2":
                                                choosenDriver2 = d2;
                                                break;
                                            case "3":
                                                choosenDriver2 = d3;
                                                break;
                                            case "4":
                                                choosenDriver2 = d4;
                                                break;
                                        }
                                    }
                                }

                            }
                        }
                    }
                }
                else
                {
                    break;
                }
            }

        }

        static string RaceCars(Car car1, Car car2)
        {

            int speed1 = car1.CalculateSpeed(Driver1);
            int speed2 = car2.CalculateSpeed(Driver1);

            if (speed1 > speed2)
            {
                return $"{car1.Model} is faster";
            }
            else if (speed2 > speed1)
            {
                return $"{car2.Model} is faster";
            }
            else
            {
                return "Speed of both cars is the same";
            }

        }
    }
}