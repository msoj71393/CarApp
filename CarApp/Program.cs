﻿using System.Data.SqlTypes;
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

        public static class Variables
        {
            public static string brand = "";
            public static string model = "";
            
            public static int kmStand = 0;
            public static int newMileage = 0;

            public static double distance = 0;

            public static bool isEngineOn = false;
        }

        private static bool MainMenu()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Car Details");
            Console.WriteLine("2) Engine Start");
            Console.WriteLine("3) Engine Off");
            Console.WriteLine("4) Trip");
            Console.WriteLine("5) Car Information");
            Console.WriteLine("6) Exit");
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
                    return false;
                default:
                    return true;
            }
        }

        private static void carDetails()
        {
            Console.Clear();
            Console.WriteLine("Enter brand: "); //asks for input.
            Variables.brand = Console.ReadLine(); //stores input in a variable.
            Console.WriteLine("brand is: " + Variables.brand + "\n");

            Console.WriteLine("Enter model: ");
            Variables.model = Console.ReadLine(); //stores input in a variable.
            Console.WriteLine("model is: " + Variables.model + "\n");

            Console.WriteLine("Enter year: "); //asks for input.
            int year = Convert.ToInt32(Console.ReadLine()); //stores input in a variable.
            Console.WriteLine("year is: " + year + "\n");

            Console.WriteLine("Enter gear type: "); //asks for input.
            char gearType = Console.ReadLine()[0]; //stores input in a variable.
            Console.WriteLine("gear type is: " + gearType + "\n"); //writes text and stored varible in console also starts a new line.

            Console.WriteLine("Enter fuel type: "); //asks for input.
            char fuelType = Console.ReadLine()[0]; //stores input in a variable.
            Console.WriteLine("fuel type is: " + fuelType + "\n");

            Console.WriteLine("Enter mileage: "); //asks for input.
            Variables.kmStand = Convert.ToInt32(Console.ReadLine()); //stores input in a variable.
            Console.WriteLine("mileage is: " + Variables.kmStand + "\n");
        }

        private static void engineStart()
        {
            Console.WriteLine("Engine on: " + "\n");
            Variables.isEngineOn = true;
        }

        private static void engineOff()
        {
            Console.WriteLine("Engine off: " + "\n");
            Variables.isEngineOn = false;
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
            Variables.distance = Double.Parse(Console.ReadLine());
            Console.WriteLine("Distance is: " + Variables.distance + "km" + "\n");

            //checks if engine is on before calculating fuel used, trip cost, and new mileage.

            if (Variables.isEngineOn == true)  
                {
                double fuelNeed = Variables.distance / kmPerL;

                Console.WriteLine("Fuel used: " + fuelNeed.ToString("#.00") + "liter" + "\n");

                double tripCost = fuelNeed * fuelPrice;

                Console.WriteLine("Trip cost: " + tripCost.ToString("#.00") + "kr." + "\n");

                Console.WriteLine("New mileage: " + (Variables.kmStand + Variables.distance).ToString("#") + "km" + "\n");

                Variables.newMileage = Convert.ToInt32(Variables.kmStand + Variables.distance);

                string s = String.Format("Fuel cost for " + Variables.distance + "km is " + tripCost.ToString("#.00") + "DKK" + "\n");

                isPalindrome();
                }
            else
                {
                Console.WriteLine("Engine is off" + "\n");
                }
        }

        private static void isPalindrome()
        {
            int origionalNumber, tempNumber, remainder, reverseNumber = 0;

            Console.WriteLine("\n");
            origionalNumber = Variables.newMileage;
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

            Console.WriteLine("After Loop");
            Console.WriteLine("Find Reverse Number");
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

        private static void carInfo()
        {
            Console.Clear();
            Console.WriteLine("Brand".PadRight(15) + "| Model".PadRight(15) + "| Mileage" + "\n");
            Console.WriteLine("-----------------------------------------------" + "\n");
            Console.WriteLine(Variables.brand.PadRight(15) + "| " + Variables.model.PadRight(13) + "| " + (Variables.kmStand + Variables.distance).ToString("#"));
            Console.WriteLine();
        }

    }
}
