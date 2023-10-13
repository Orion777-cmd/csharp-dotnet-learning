// See https://aka.ms/new-console-template for more information
using System;

namespace whileIteration
{
    class program
{
    static void Main(string[] args){
        bool displayMenu = true;
        while(displayMenu){
            displayMenu = MainMenu();
        }
        
    }

    private static bool MainMenu(){
        Console.WriteLine("Choose an option: ");
        Console.WriteLine("1) Print Numbers");
        Console.WriteLine("2) Guessing Game");
        Console.WriteLine("3) Exit");
        int result = int.Parse(Console.ReadLine());
        switch (result){
            case 1:
                printNumbers();
                break;
            case 2:
                guessingGame();
                break;
            case 3:
                return false;
            default:
                return true;
                
        }
        return true;

    }

    private static void printNumbers(){
        Console.WriteLine("Print Numbers");
        Console.WriteLine("Type a number: ");
        int result = int.Parse(Console.ReadLine());
        int counter = 1;
        while (counter <= result){
            Console.Write(counter);
            Console.Write("-");
            counter++;
        }
        Console.WriteLine();
        MainMenu();
    }  

    private static void guessingGame(){
        Console.Clear();
        Console.WriteLine("Guessing Game");
        Random myRandom = new Random();
        int randomNumber = myRandom.Next(1,11);
        int guesses = 0;
        bool incorrect = true;
        do{
            Console.WriteLine("Guess a number between 1 and 10: ");
            string result = Console.ReadLine();
            guesses++;
            if (result == randomNumber.ToString()){
                incorrect = false;
            }else{
                Console.WriteLine("Wrong!");
            }
        }while(incorrect);
        Console.WriteLine("Correct! It took you {0} guesses", guesses);
        MainMenu();
    } 
}
}