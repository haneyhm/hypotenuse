using System;

namespace GitHubTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0.0;
            double b = 0.0;
            double c = 0.0;

            //read in miles
            a = getDouble("Enter a side length: ");

            //read in gallons
            b = getDouble("Enter b side length: ");

            //compute mpg
            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine("you got " + c + " as the hypotenuse.");
        }

        public static double getDouble(string prompt)
        {
            string temp;
            double value = 0;
            Console.WriteLine(prompt);
            temp = Console.ReadLine();
            value = Double.Parse(temp);
            return value;
        }
    }


        //create program that calculates the hypotenuse of a triangle
    
}
