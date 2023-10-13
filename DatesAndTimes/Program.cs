using System;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args){
            DateTime myValue = DateTime.Now;
            Console.WriteLine(myValue.ToString());

            Console.WriteLine("short Date String: " + myValue.ToShortDateString());
            Console.WriteLine("short Time string: " + myValue.ToShortTimeString());
            Console.WriteLine("long time string: " + myValue.ToLongTimeString());

            Console.WriteLine("adding some value: "+ myValue.AddDays(3).ToLongDateString());
            Console.WriteLine("adding some hour" + myValue.AddHours(3).ToLongTimeString());
            Console.WriteLine("subtracting days" + myValue.AddDays(-3).ToLongDateString());

            Console.WriteLine("months: " + myValue.Month);

            DateTime myBirthDay = new DateTime(2002, 12, 2);
            Console.WriteLine("birthday: " + myBirthDay.ToShortDateString());

            DateTime myAnotherBirthDay = DateTime.Parse("12/2/2002");
            TimeSpan myAge = DateTime.Now.Subtract(myAnotherBirthDay);

            Console.WriteLine("my calculated age is: " + myAge.TotalDays / 365);

            Console.ReadLine();
        }
    }
}