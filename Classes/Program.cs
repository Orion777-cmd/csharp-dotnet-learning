using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color
            );

            myCar.Make = "Toyota";
            myCar.Model = "Camry";
            myCar.Year = 2019;
            myCar.Color = "Black";

            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color
            );

            Console.ReadLine();

            // to create methods with out creating an instance of the class
            // we use static keyword
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car(){
            this.Make = "Nissan";
            this.Model = "Altima";
            this.Year = 2018;
            this.Color = "White";

        }

        //overloading
        public Car(string make, string model, int year, string color){
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Color = color;
        }

        public static void myMethod(){
            Console.WriteLine("Called the static myMethod");
        }
    }
}