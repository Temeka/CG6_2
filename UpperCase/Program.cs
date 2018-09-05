using System;

namespace UpperCase
{
    class Program
    {
        static void Main(string[] args)
        {
            //instructing user to type a sentence
            Console.WriteLine("Please type a sentence: ");

            //declaring the string 
            string myString = Console.ReadLine();

            //instructing comipler to make all letters UPPER case
            myString = myString.ToUpper();

            //ouput should read COMFORT AND SUCCESS ARE #GOALS!
            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
