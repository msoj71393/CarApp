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

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Car Details");
            Console.WriteLine("2) Trip");
            Console.WriteLine("3) Car Information");
            Console.WriteLine("4) Exit");
            Console.Write("\r\nSelec an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    carDetails();
                    return true;
                case "2":
                    trip();
                    return true;
                case "3":
                    carInfo();
                    return true;
                case "4":
                    return false;
                default:
                    return true;
            }
        }

        private static void carDetails()
        {
            Console.Clear();
            Console.WriteLine("Indtast bilmærke: "); //asks for input.
            string brand = Console.ReadLine(); //stores input in a variable.
            Console.WriteLine("bilmærket er: " + brand + "\n");

            Console.WriteLine("Indtast bilmodel: ");
            string model = Console.ReadLine(); //stores input in a variable.
            Console.WriteLine("bilmærket er: " + model + "\n");

            Console.WriteLine("Indtast årgang: "); //asks for input.
            int year = Convert.ToInt32(Console.ReadLine()); //stores input in a variable.
            Console.WriteLine("årgangen er: " + year + "\n");

            Console.WriteLine("Indtast geartypen: "); //asks for input.
            char gearType = Console.ReadLine()[0]; //stores input in a variable.
            Console.WriteLine("geartypen er: " + gearType + "\n"); //writes text and stored varible in console also starts a new line.

            Console.WriteLine("Indtast brændstoftype: "); //asks for input.
            char fuelType = Console.ReadLine()[0]; //stores input in a variable.
            Console.WriteLine("Brændstoftypen er: " + fuelType + "\n");

            Console.WriteLine("Indtast kilometerstand: "); //asks for input.
            int kmStand = Convert.ToInt32(Console.ReadLine()); //stores input in a variable.
            Console.WriteLine("Kilometerstand er: " + kmStand + "\n");
        }

        private static void trip()
        { 
            Console.Clear();
            Console.WriteLine("Indtast km/l: "); //asks for input.
            double kmPerL = Double.Parse(Console.ReadLine()); //stores input in a variable.
            Console.WriteLine("km/l er: " + kmPerL + "\n"); //writes text and stored varible in console also starts a new line.

            Console.WriteLine("Indtast brændstofpris: "); //asks for input.
            double fuelPrice = Double.Parse(Console.ReadLine()); //stores input in a variable.
            Console.WriteLine("Brændstofpris er: " + fuelPrice + "\n"); //writes text and stored varible in console also starts a new line.

            Console.WriteLine("Distance: ");
            double distance = Double.Parse(Console.ReadLine());
            Console.WriteLine("Distance er: " + distance + "km" + "\n");

            double fuelNeed = distance / kmPerL;

            Console.WriteLine("Brændstofforbrug: " + fuelNeed.ToString("#.00") + "liter" + "\n");

            double tripCost = fuelNeed * fuelPrice;

            Console.WriteLine("Tur pris: " + tripCost.ToString("#.00") + "kr." + "\n");

            Console.WriteLine("Ny kilometerstand: " + (kmStand + distance).ToString("#") + "km" + "\n");
         
            string s = String.Format("Brændstofudgifterne for " + distance + "km er " + tripCost.ToString("#.00") + "DKK" + "\n");
            Console.WriteLine(s);
        }

        private static void carInfo()
        {
            Console.Clear();
            Console.WriteLine("Bilmærke".PadRight(15) + "| Model".PadRight(15) + "| Kilometertal" + "\n");
            Console.WriteLine("-----------------------------------------------" + "\n");
            Console.WriteLine(brand.PadRight(15) + "| " + model.PadRight(13) + "| " + (kmStand + distance).ToString("#"));
        }

    }
}
