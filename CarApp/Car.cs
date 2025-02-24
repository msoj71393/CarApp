using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
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
            get => model;
            set => model = value;
        }

        public int Year
        {
            get; set;
        }

        public char GearType
        {
            get; set;
        }

        public char FuelType
        {
            get; set;
        }

        public int Mileage
        {
            get; set;
        }

        public int NewMileage
        {
            get; set;
        }

        public double Distance
        {
            get; set;
        }

        public bool IsEngineOn
        {
            get; set;
        }

        public double KmPerL
        {
            get; set;
        }

        public double FuelPrice
        {
            get; set;
        }

        public string Owner
        {
            get; set;
        }

        //Is needed to correctly display output in carPark().
        public override string ToString()
        {
            return $"Owner: {this.Owner}, Brand: {this.Brand}, Model: {this.Model}, Year: {this.Year}";
        }
    }
}
