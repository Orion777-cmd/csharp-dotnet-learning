using System;
using System.Collections;

namespace understandingScope
{
    class Program
    {
        static void Main(string[] args)
        {
            // a variable inside a block is only accessible inside that block
            // it also applies to object references

            // private is accessible to all the members of the class
            Car myCar = new Car();
            myCar.DoSomething();

            Bus myBus = new Bus();
            myBus.Make = "Toyota";
            myBus.Model = "Cutlas Supreme";

            Bus myBus2 = new Bus();
            myBus2.Make = "Geo";
            myBus2.Model = "Prism";

            Book b1 = new Book();
            b1.Title = "Harry Potter";
            b1.Author = "JK Rowling";
            b1.ISBN = "123456789";

            Book b2 = new Book();
            b2.Title = "Lord of the Rings";
            b2.Author = "Tolkein";
            b2.ISBN = "987654321";

            // ArrayLists

            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(myBus);
            myArrayList.Add(myBus2);
            // myArrayList.Add(b1);

            foreach (Bus bus in myArrayList)
            {
                Console.WriteLine(bus.Make);
            }

            // with notion of generics by providing a datatype for the arraylist
            List<Bus> myList = new List<Bus>();
            myList.Add(myBus);
            myList.Add(myBus2);

            Console.WriteLine(myList[0].Make);

            // DICTIONARY
            Dictionary<string, Bus> myDictionary = new Dictionary<string, Bus>();
            myDictionary.Add(myBus.Make, myBus);
            myDictionary.Add(myBus2.Make, myBus2);


            string[] names = { "Bob", "Steve", "Brian", "Chuck" };

            // object Initializer ( no need of a constructor)
            Bus myBus3 = new Bus() { Make = "BMW", Model = "X5" };
            Bus myBus4 = new Bus() { Make = "Toyota", Model = "Camry" };

            //collecton Initializer
            List<Bus> myBusList = new List<Bus>() {
                new Bus() { Make = "BMM", Model = "X7" },
                new Bus() { Make = "Toyot", Model = "Cary" }
            };


        }
    }

    class Car
    {
        public void DoSomething()
        {
            Console.WriteLine(HelperMethod());
        }

        private string HelperMethod()
        {
            return "hello world!";
        }
    }

    class Bus
    {
        public string Make { get; set; }
        public string Model { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}