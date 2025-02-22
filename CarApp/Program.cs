using System.Data.SqlTypes;
using System.Diagnostics;
using System.Reflection;
using System.Xml;

namespace CarApp
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        public static class Car
        {
            public static string brand = "";

            public static string model = "";

            public static int kmStand = 0;
            public static int newMileage = 0;

            public static double distance = 0;

            public static bool isEngineOn = false;

        }



        public static class Cars
        {
            public static List<string> brand = new List<string>();
            public static List<string> model = new List<string>();
            public static List<int> year = new List<int>();
            public static List<string> owner = new List<string>();
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
            Car.brand = Console.ReadLine(); //stores input in a variable.
            Console.WriteLine("brand is: " + Car.brand + "\n"); //writes text and stored varible in console also starts a new line.

            Console.WriteLine("Enter model: ");
            Car.model = Console.ReadLine(); //stores input in a variable.
            Console.WriteLine("model is: " + Car.model + "\n"); //writes text and stored varible in console also starts a new line.

            Console.WriteLine("Enter year: "); //asks for input.
            int year = Convert.ToInt32(Console.ReadLine()); //stores input in a variable.
            Console.WriteLine("year is: " + year + "\n"); //writes text and stored varible in console also starts a new line.

            Console.WriteLine("Enter gear type: "); //asks for input.
            char gearType = Console.ReadLine()[0]; //stores input in a variable.
            Console.WriteLine("gear type is: " + gearType + "\n"); //writes text and stored varible in console also starts a new line.

            Console.WriteLine("Enter fuel type: "); //asks for input.
            char fuelType = Console.ReadLine()[0]; //stores input in a variable.
            Console.WriteLine("fuel type is: " + fuelType + "\n"); //writes text and stored varible in console also starts a new line.

            Console.WriteLine("Enter mileage: "); //asks for input.
            Car.kmStand = Convert.ToInt32(Console.ReadLine()); //stores input in a variable.
            Console.WriteLine("mileage is: " + Car.kmStand + "\n"); //writes text and stored varible in console also starts a new line.
        }

        //Start engine
        private static void engineStart()
        {
            Console.WriteLine("Engine on: " + "\n"); //Writes in console that the car is on and creates a new line.
            Car.isEngineOn = true; //Turns the bool isEngineOn to true.
        }
        
        //Stops engine
        private static void engineOff()
        {
            Console.WriteLine("Engine off: " + "\n"); //Writes in console that the car is on and creates a new line.
            Car.isEngineOn = false; //Turns the bool isEngineOn to false.
        }

        //trip() asks for km/l, fuel cost and drive distance values before calculating fuel used, trip cost, and new mileage.
        private static void trip()
        { 
            Console.Clear();
            Console.WriteLine("Enter km/l: "); //asks for input.
            double kmPerL = Double.Parse(Console.ReadLine()); //stores input in a variable.
            Console.WriteLine("km/l is: " + kmPerL + "\n"); //writes text and stored varible in console also starts a new line.

            Console.WriteLine("Enter fuel cost: "); //asks for input.
            double fuelPrice = Double.Parse(Console.ReadLine()); //stores input in a variable.
            Console.WriteLine("Fuel cost is: " + fuelPrice + "\n"); //writes text and stored varible in console also starts a new line.

            Console.WriteLine("Distance: ");
            Car.distance = Double.Parse(Console.ReadLine());
            Console.WriteLine("Distance is: " + Car.distance + "km" + "\n");

            //checks if engine is on before calculating fuel used, trip cost, and new mileage.
            if (Car.isEngineOn == true) //Check if isEngineOn is true if not it goes to the else statement.
            {
                double fuelNeed = Car.distance / kmPerL;  //Calculates fuel need for the given distance.

                Console.WriteLine("Fuel used: " + fuelNeed.ToString("#.00") + "liter" + "\n"); //Writes the fuel needed per liter with two decimalplaces.

                double tripCost = fuelNeed * fuelPrice; //Calculates the fuel price for the given distance.

                Console.WriteLine("Trip cost: " + tripCost.ToString("#.00") + "kr." + "\n"); //Writes the fuel price in kr. with two decimalplaces.

                Console.WriteLine("New mileage: " + (Car.kmStand + Car.distance).ToString("#") + "km" + "\n"); //Writes the need mileage with tw o decimalplaces in km.

                Car.newMileage = Convert.ToInt32(Car.kmStand + Car.distance); //Stores the need mileage in the variable newMileage.

                string s = String.Format("Fuel cost for " + Car.distance + "km is " + tripCost.ToString("#.00") + "DKK" + "\n"); //Writes a string with fuel cost per km and the price in DKK.

                isPalindrome(); //Call isPalindrome method.
                }
            else
                {
                Console.WriteLine("Engine is off" + "\n"); //Writes Engine is off if the isEngineOn statement is false.
                }
        }

        //Checks to see if the mileage of the car in question is a palindrome.
        private static void isPalindrome()
        {
            int origionalNumber, tempNumber, remainder, reverseNumber = 0;

            Console.WriteLine("\n");
            origionalNumber = Car.newMileage;
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
            Console.WriteLine(Car.brand.PadRight(15) + "| " + Car.model.PadRight(13) + "| " + (Car.kmStand + Car.distance).ToString("#"));
            Console.WriteLine();
        }

        //Let's us add as many cars as we want to our carpark and writes out data on the cars.
        private static void carPark()
        {
            Console.WriteLine("Enter number of cars: ");
            int numbCars = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numbCars; i++)
            {
                Console.WriteLine("Enter owner of car: ");
                Cars.owner.Add(Console.ReadLine());

                Console.WriteLine("Enter brand: ");
                Cars.brand.Add(Console.ReadLine());

                Console.WriteLine("Enter model: ");
                Cars.model.Add(Console.ReadLine());

                Console.WriteLine("Enter year: ");
                Cars.year.Add(Convert.ToInt32(Console.ReadLine()));
            }

            for (int i = 0; i < Cars.brand.Count; i++)
            {
                Console.WriteLine(Cars.owner[i] + " ".PadRight(10) + Cars.brand[i] + " ".PadRight(10) + Cars.model[i] + " ".PadRight(10) + Cars.year[i] + "\n");
            }
        }

        //Loads an image from storage.
        private static void domainModel()
        {
            var p = new Process();
            p.StartInfo = new ProcessStartInfo(@"G:\\Datamatiker\\Visual Studio Code\\CarApp\\CarApp\\DomainModelCarApp.png")
            {
                UseShellExecute = true
            };
            p.Start();

        }
    }
}

//public class Car
//{
//    public string Brand { get; set; }
//    public string Model { get; set; }
//    public int Year { get; set; }
//    public Car(string brand, string model, int year)
//    {
//        Brand = brand;
//        Model = model;
//        Year = year;
//    }
//}

//public class CarCollection
//{
//    private List<Car> cars = new List<Car>();
//    public void AddCar(Car car)
//    {
//        cars.Add(car);
//    }
//    public void RemoveCar(Car car)
//    {
//        cars.Remove(car);
//    }
//    public List<Car> GetCars()
//    {
//        return cars;
//    }
//    public void RemoveCar(int id)
//    {
//        cars.RemoveAt(id);
//    }

//int index = 0;
//        foreach (var car in carCollection.GetCars())
//        {
//            Console.WriteLine($"Id: {index} Make: {car.Make}, Model: {car.Model}, Year: {car.Year}");
//            index++;
//        }
//}


