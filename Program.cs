using System;

namespace myApp
{
    class Program
    {
      //
        static void Main(string[] args)
        {
            string name = "Mateo Rosenberg";
            int age = 35;

            Console.WriteLine(name + " is " + age );
            Console.WriteLine("{0} is {1}", name, age);
            Console.WriteLine("The current time is " + DateTime.Now);
          
        }
    }
}
