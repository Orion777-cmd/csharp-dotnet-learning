using System;
using System.Collections.Generic;
using System.Linq;

namespace LanguageIntegratedQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>()
            {
                new Car() { VIN = "A1", Make = "BMW", Model = "550i", StickerPrice = 55000, Year = 2009 },
                new Car() { VIN = "B2", Make = "Toyota", Model = "4Runner", StickerPrice = 35000, Year = 2010 },
                new Car() { VIN = "C3", Make = "BMW", Model = "745li", StickerPrice = 75000, Year = 2008 },
                new Car() { VIN = "D4", Make = "Ford", Model = "Escape", StickerPrice = 25000, Year = 2008 },
                new Car() { VIN = "E5", Make = "BMW", Model = "55i", StickerPrice = 57000, Year = 2010 }
            };

            // LINQ query

            // we use var so that the compiler can infer the type of the variable
            var bmws = from car in myCars
                       where car.Make == "BMW" && car.Year == 2010
                       select car;

            // extracting only some values and making them anonymous types
            var newCars = from Car in myCars
                          where Car.Make == "BMW"
                          select new { Car.Make, Car.Model };
            
            Console.WriteLine(newCars.GetType());

            var orderCars = from car in myCars
                                orderby car.Year descending
                                select car;

            // LINQ method
            var findCar = myCars.First(p => p.Make == "BMW");

            var orderedCars = myCars.OrderByDescending(p => p.Year);

            var orderedFirstBMW = myCars.OrderByDescending(p => p.Year).First(p => p.Make == "BMW");

            var anotherBmws = myCars.Where(p => p.Make == "BMW");

            foreach(var car in anotherBmws){
                Console.WriteLine("{0} {1}", car.Model, car.VIN);
            }
            foreach (var car in bmws)
            {
                Console.WriteLine("{0} {1}", car.Model, car.VIN);
            }

            Console.WriteLine(myCars.TrueForAll(p => p.Year > 2007));

            Console.WriteLine(myCars.Exists(p => p.Model == "745li"));

            Console.WriteLine(myCars.Sum(p => p.StickerPrice));

            myCars.ForEach(p => Console.WriteLine("{0} {1:C}", p.VIN, p.StickerPrice));
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int StickerPrice { get; set; }
    }
}