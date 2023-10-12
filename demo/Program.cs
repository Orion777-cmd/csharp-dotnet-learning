// See https://aka.ms/new-console-template for more information


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


string str= "you can get what you want out of life " + "if you help enough other people get what they want";

string reversedString = "";
for (int i = str.Length-1; i >= 0; i--){
    reversedString += str[i];
}

Console.WriteLine(reversedString);

Char[] charArray = str.ToCharArray();

Array.Reverse(charArray);
Console.WriteLine(charArray);


