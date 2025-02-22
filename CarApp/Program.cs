using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using static test.Program;

namespace test
{
    internal class Program
    {


        public class Car
        {
            private string brand = "";
            private string model = "";
            private int year;
            private char gearType;
            private char fuelType;
            private int mileage;
            private int newMileage;
            private double distance;
            private bool isEngineOn = false;
            private double kmPerL;
            private double fuelPrice;
            private string owner = "";

            public Car(string owner, string brand, string model, int year)
            {
                this.owner = owner;
                this.brand = brand;
                this.model = model;
                this.year = year;
            }

            public string Brand
            {
                get
                {
                    return brand;
                }
                set
                {
                    brand = value;
                }

            }

            public string Model
            {
                get
                {
                    return model;
                }
                set
                {
                    model = value;
                }
            }

            public int Year
            {
                get
                {
                    return year;
                }
                set
                {
                    year = value;
                }
            }

            public char GearType
            {
                get
                {
                    return gearType;
                }
                set
                {
                    gearType = value;
                }
            }

            public char FuelType
            {
                get
                {
                    return fuelType;
                }
                set
                {
                    fuelType = value;
                }
            }

            public int Mileage
            {
                get
                {
                    return mileage;
                }
                set
                {
                    mileage = value;
                }
            }

            public int NewMileage
            {
                get
                {
                    return newMileage;
                }
                set
                {
                    newMileage = value;
                }
            }

            public double Distance
            {
                get
                {
                    return distance;
                }
                set
                {
                    distance = value;
                }
            }

            public bool IsEngineOn
            {
                get
                {
                    return isEngineOn;
                }
                set
                {
                    isEngineOn = value;
                }
            }

            public double KmPerL
            {
                get
                {
                    return kmPerL;
                }
                set
                {
                    kmPerL = value;
                }
            }

            public double FuelPrice
            {
                get
                {
                    return fuelPrice;
                }
                set
                {
                    fuelPrice = value;
                }
            }

            public string Owner
            {
                get
                {
                    return owner;
                }
                set
                {
                    owner = value;
                }
            }

            //Is needed to correctly display output in carPark().
            public override string ToString()
            {
                return $"Owner: {this.Owner}, Brand: {this.Brand}, Model: {this.Model}, Year: {this.Year}";
            }
        }

        //Declares and instance of car.
        static Car car;

        static void Main(string[] args)
        {
            car = new Car("", "", "", 0);

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Car Details");
            Console.WriteLine("2) Engine Start");
            Console.WriteLine("3) Engine Off");
            Console.WriteLine("4) Trip");
            Console.WriteLine("5) Car Information");
            Console.WriteLine("6) Carpark");
            Console.WriteLine("7) Domain Model");
            Console.WriteLine("8) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    carDetails();
                    return true;
                case "2":
                    engineStart();
                    return true;
                case "3":
                    engineOff();
                    return true;
                case "4":
                    trip();
                    return true;
                case "5":
                    carInfo();
                    return true;
                case "6":
                    carPark();
                    return true;
                case "7":
                    domainModel();
                    return true;
                case "8":
                    return false;
                default:
                    return true;
            }
        }

        private static void carDetails()
        {
            Console.Clear();

            Console.WriteLine("Enter brand: "); //asks for input.
            car.Brand = Console.ReadLine(); //stores input in a variable.
            Console.WriteLine($"brand name is {car.Brand} \n"); //writes text and stored varible in console also starts a new line.

            Console.WriteLine("Enter model: ");
            car.Model = Console.ReadLine();
            Console.WriteLine($"model name is {car.Model} \n");

            Console.WriteLine("Enter year: ");
            car.Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"year is {car.Year} \n");

            Console.WriteLine("Enter gear type: ");
            car.GearType = Console.ReadLine()[0];
            Console.WriteLine($"gear type is {car.GearType} \n");

            Console.WriteLine("Enter fuel type: ");
            car.FuelType = Console.ReadLine()[0];
            Console.WriteLine($"fuel type is {car.FuelType} \n");

            Console.WriteLine("Enter mileage: ");
            car.Mileage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"mileage is {car.Mileage} \n");
        }

        //Start engine
        private static void engineStart()
        {
            Console.WriteLine("Engine on: " + "\n"); //Writes in console that the car is on and creates a new line.
            car.IsEngineOn = true; //Turns the bool isEngineOn to true.
        }

        //Stops engine
        private static void engineOff()
        {
            Console.WriteLine("Engine off: " + "\n"); //Writes in console that the car is on and creates a new line.
            car.IsEngineOn = false; //Turns the bool isEngineOn to false.
        }

        private static void trip()
        {
            Console.Clear();

            Console.WriteLine("Enter km/l: "); //asks for input.
            car.KmPerL = Double.Parse(Console.ReadLine()); //stores input in a variable.
            Console.WriteLine($"km/l is: {car.KmPerL} \n"); //writes text and stored varible in console also starts a new line.

            Console.WriteLine("Enter fuel cost: "); //asks for input.
            car.FuelPrice = Double.Parse(Console.ReadLine()); //stores input in a variable.
            Console.WriteLine($"km/l is: {car.FuelPrice} \n"); //writes text and stored varible in console also starts a new line.

            Console.WriteLine("Distance: ");
            car.Distance = Double.Parse(Console.ReadLine());
            Console.WriteLine($"Distance is: {car.Distance} km \n");

            if (car.IsEngineOn == true) //Check if isEngineOn is true if not it goes to the else statement.
            {
                double fuelNeed = car.Distance / car.KmPerL;  //Calculates fuel need for the given distance.

                Console.WriteLine("Fuel used: " + fuelNeed.ToString("#.00") + "liter" + "\n"); //Writes the fuel needed per liter with two decimalplaces.

                double tripCost = fuelNeed * car.FuelPrice; //Calculates the fuel price for the given distance.

                Console.WriteLine("Trip cost: " + tripCost.ToString("#.00") + "kr." + "\n"); //Writes the fuel price in kr. with two decimalplaces.

                Console.WriteLine("New mileage: " + (car.Mileage + car.Distance).ToString("#") + "km" + "\n"); //Writes the need mileage with tw o decimalplaces in km.

                car.NewMileage = Convert.ToInt32(car.Mileage + car.Distance); //Stores the need mileage in the variable newMileage.

                string s = String.Format("Fuel cost for " + car.Distance + "km is " + tripCost.ToString("#.00") + "DKK" + "\n"); //Writes a string with fuel cost per km and the price in DKK.

                isPalindrome(); //Call isPalindrome method.
            }
            else
            {
                Console.WriteLine("Engine is off" + "\n"); //Writes Engine is off if the isEngineOn statement is false.
            }
        }
        private static void isPalindrome()
        {
            int origionalNumber, tempNumber, remainder, reverseNumber = 0;

            Console.WriteLine("\n");
            origionalNumber = car.NewMileage;
            Console.WriteLine("\n");

            tempNumber = origionalNumber;

            while (origionalNumber > 0)
            {
                remainder = origionalNumber % 10;
                Console.WriteLine("Remainder = " + remainder);
                reverseNumber = reverseNumber * 10 + remainder;
                Console.WriteLine("Reverse number = " + reverseNumber);
                origionalNumber = origionalNumber / 10;
                Console.WriteLine("Origional number = " + origionalNumber);
                Console.WriteLine("\n");
            }

            Console.WriteLine("Origional Number : {0}", tempNumber);
            Console.WriteLine("Reverse number : {0}", reverseNumber);

            Console.WriteLine("=========================");
            if (tempNumber == reverseNumber)
            {
                Console.WriteLine("Milage is a palindrome");
            }
            else
            {
                Console.WriteLine("Milage is not a palindrom");
            }

            Console.WriteLine("\n\n");
        }

        //presents the car data is a table
        private static void carInfo()
        {
            Console.Clear();

            Console.WriteLine("Brand".PadRight(15) + "| Model".PadRight(15) + "| Mileage" + "\n");
            Console.WriteLine("-----------------------------------------------" + "\n");
            Console.WriteLine(car.Brand.PadRight(15) + "| " + car.Model.PadRight(13) + "| " + (car.Mileage + car.Distance).ToString("#"));
            Console.WriteLine();
        }

        //Let's us add as many cars as we want to our carpark and writes out data on the cars.
        public static void carPark()
        {
            List<Car> carList = new List<Car>();

            Console.WriteLine("Enter number of cars: ");
            int numbCars = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numbCars; i++)
            {
                Console.WriteLine("Enter owner: ");
                string owner = Console.ReadLine();

                Console.WriteLine("Enter brand: ");
                string brand = Console.ReadLine();

                Console.WriteLine("Enter model: ");
                string model = Console.ReadLine();

                Console.WriteLine("Enter year: ");
                int year = Convert.ToInt32(Console.ReadLine());

                carList.Add(new Car(owner, brand, model, year));
            }

            foreach (var car in carList)
            {
                Console.WriteLine(car);
            }
        }

        //Loads an image from storage.
        private static void domainModel()
        {
            var p = new Process();
            p.StartInfo = new ProcessStartInfo(@"G:\Datamatiker\Visual Studio Code\test\test\DomainModelCarApp.png") //Relative path of the png.
            {
                UseShellExecute = true
            };
            p.Start();
        }
    }
}


