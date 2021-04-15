using System;

namespace oefening1sprint12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------abstraction-------");
            //car class abstraction
            VehicleA h = new VehicleA();
            h.Brand = "Hyundai";
            h.Color = "Green";
            h.Price = 12000;
            h.CarDetails();

            Console.WriteLine("-------inheritance-------");

            //car class inheritance
            Car m = new Car();
            m.Brand = "Mercedes";
            m.Color = "white";
            m.Price = 19000;
            m.VehicleDetails();

            Console.WriteLine("-------------------------");

            //truck class inheritance
            Truck v = new Truck();
            v.Brand = "volvo";
            v.Color = "black";
            v.Price = 32000;
            v.Weight = 42000;
            v.TruckDetails();

            Console.WriteLine("------polymorphism-------");

            CarP s = new CarP();
            TruckP n = new TruckP();

            s.Break();
            n.Break();
        }

    #region abstractie class
        public class VehicleA
        {
            private string brand;
            private int price;
            private string color;

            public string Brand
            {
                get { return brand; }
                set { brand = value; }
            }

            public int Price
            {
                get { return price; }
                set { price = value; }
            }

            public string Color
            {
                get { return color; }
                set { color = value; }
            }

            public void CarDetails()
            {
                Console.WriteLine("Brand: " + Brand);
                Console.WriteLine("Price: " + Price);
                Console.WriteLine("color: " + Color);
            }
        }
    #endregion
    #region inheritance class
    public class Vehicle
        {
            public int Weight { get; set; }
            public string Color { get; set; }
            public int Price { get; set; }
            public string Brand { get; set; }
        }

        class Car : Vehicle
        {
            public void VehicleDetails()
            {
                Console.WriteLine("color: " + Color);
                Console.WriteLine("Model: " + Brand);
                Console.WriteLine("Price: " + Price);
            }
        }

        class Truck : Vehicle
        {
            public void TruckDetails()
            {
                Console.WriteLine("color: " + Color);
                Console.WriteLine("Model: " + Brand);
                Console.WriteLine("Price: " + Price);
                Console.WriteLine("weight: " + Weight);
            }
        }
        #endregion
    #region polymorfisme class
        class VehicleP 
        {
            public void Break()
            {
                Console.WriteLine("The vehicle breaks");
            }
        }

        class CarP : VehicleP
        {
            public void Break()
            {
                Console.WriteLine("The car stops");
            }
        }

        class TruckP : VehicleP
        {
            public void Break()
            {
                Console.WriteLine("The truck stops");
            }
        }

        #endregion

    }
}
