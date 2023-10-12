using System;
using System.Text;

namespace stringText
{
    class Program{
        static void Main(string[] args){
            // @ will make the the backslash to be considered as a normal character
            // not as an escaping character
            string myStr = @"Go to your \life";
            string myString = string.Format("{0} {1}", "Abiy", "Biru");
            Console.WriteLine(myString);

            string myBirr = string.Format("{0:C}", 123.45);
            Console.WriteLine(myBirr);

            string myLongNumber = string.Format("{0:N}", 1234546789);
            Console.WriteLine(myLongNumber);

            string myPercentage = string.Format("{0:P}", .123);
            Console.WriteLine(myPercentage);

            // string myPhoneNumber = string.Format("{phone number: (###) ###-####}", 1234567890);
            // Console.WriteLine(myPhoneNumber);

            string myMusic = " That summer we took threes across the board ";
            string mySubMusic = myMusic.Substring(6);
            string myUpperMusic = myMusic.ToUpper();

            string replacedMusic = myMusic.Replace(" ", "--");

            string removedSubMusic = myMusic.Remove(6, 14);

            string trimmedMusic = string.Format("{0} --Length after : {1}", 
                myMusic.Length,
                myMusic.Trim().Length
            );

            StringBuilder newString = new StringBuilder();

            for(int i = 1; i < 100; i++){
                newString.Append("--");
                newString.Append(i);
            }

            Console.WriteLine(newString);

            Console.ReadLine();
        }
    }
}