using System;

namespace myApp
{
    class Program
    {
      //
        static void Main(string[] args)
        {
            // string name = "Mateo Rosenberg";
            // int age = 35;
            // Console.WriteLine(name + " is " + age );
            // Console.WriteLine("{0} is {1}", name, age);
            // Console.WriteLine("The current time is " + DateTime.Now);

            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Matthew Rosenberg";

            //Change text to green
            Console.ForegroundColor = ConsoleColor.Green;
            //text color
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            //Reset text color
            Console.ResetColor();
            //Ask user name
            Console.WriteLine("What is your name?");
            //get user Input
            string input = Console.ReadLine();
            


            
          
        }
    }
}
