// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Hello, World!");
int x = 7;
int y =  x + 3;
Console.WriteLine(y);

Console.WriteLine("What is you name?: ");
string? firstName = Console.ReadLine();

Console.WriteLine("the name you entered is: " + firstName);


if (firstName == "Abiy"){
    Console.WriteLine("Hello Abiy");
}else{
    Console.WriteLine("Hello Stranger");
}


Console.WriteLine("What is your age?: ");
int age = Convert.ToInt32(Console.ReadLine());
string message = age >= 18 ? "you can enjoy the club" : "you are too young";

Console.WriteLine("with age {0}, {1}", age, message);