using System;

namespace myApp
{
  class Program
  {
    //
    static void Main(string[] args)
    {
      GetAppInfo();
      Console.WriteLine("What is your name?");
      //get user Input
      string inputName = Console.ReadLine();
      Console.WriteLine("Hello {0}, lets play a game...", inputName);

      while (true)
      {
        // int correctNumber = 7;
        Random random = new Random();
        int correctNumber = random.Next(1, 10);

        int guess = 0;
        Console.WriteLine("Guess a number between 1 and 10");

        //While guess is not correnct
        while (guess != correctNumber)
        {
          string input = Console.ReadLine();

          //if input is not a number
          if (!int.TryParse(input, out guess))
          {
            //Change text color
            Console.ForegroundColor = ConsoleColor.Red;
            //Tell user its not a number
            Console.WriteLine("Please enter a valid number");
            Console.ResetColor();
            //Keep Going
            continue;
          }

          //Cast to int and put in guess
          guess = Int32.Parse(input);

          //Match guess to correct Number
          if (guess != correctNumber)
          {
            // Change text color
            Console.ForegroundColor = ConsoleColor.Red;
            //Tell User Wrong Guess
            Console.WriteLine("Guess a number between 1 and 10");
            // Reset Text Color
            Console.ResetColor();
          }
        }

        if (guess == correctNumber)
        {
          Console.ForegroundColor = ConsoleColor.Green;
          Console.WriteLine("Congrats you are awesome!");
          Console.ResetColor();
          Console.WriteLine("Want to play again? [Y or N]" );
          string answer = Console.ReadLine().ToUpper();

          if (answer == "Y") {
            continue;
          }
          else if (answer == "N") {
            return;
          }
          else {
            return;
          }
        }
      }

    }
    static void GetAppInfo() {
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
    }

  }
}
