using System;

namespace UpperCase
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring string 
            string MyWords = "Comfort and Success are #GOALS!";

            //instructing comipler to make all letters UPPER case
            MyWords = MyWords.ToUpper();

            //ouput should read COMFORT AND SUCCESS ARE #GOALS!
            Console.WriteLine(MyWords);
            Console.ReadLine();
        }
    }
}
