using System;
namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfCupOfCoffee = 0;
            Console.WriteLine("Welcome to my application!");
            var fullName = "Milagro Scardigno";
            var today = DateTime.Today;
            Console.WriteLine(fullName + " " + "drinks " + numberOfCupOfCoffee + " cups of coffee ☕️ a day.");
            Console.WriteLine("Today's date is " + today + ".");
            Console.WriteLine("\n");
            Console.WriteLine("What is your name? ");
            var userName = Console.ReadLine();
            Console.WriteLine("Greetings " + userName + "!" + " Welcome to our app.");
            Console.Write("What is your favorite number:? ");
            var favoriteNumber = Console.ReadLine();
            Console.WriteLine(favoriteNumber);
            Console.WriteLine("That's a cool number");
            Console.WriteLine(userName + "'s favorite number is: " + favoriteNumber);
            Console.WriteLine("\n");
            //Asking for two numbers
            Console.WriteLine("Pick one number: ");
            //converting string to int
            var firstNumberAsString = Double.Parse(Console.ReadLine());
            Console.WriteLine("Pick a second number: ");
            var secondNumberAsString = Double.Parse(Console.ReadLine());
            Console.Write("The firstNumber and secondNumber added together equals: ");
            var sum = firstNumberAsString + secondNumberAsString;
            Console.WriteLine(sum); //checking if they are numbers
            Console.WriteLine("Bye bye " + userName + "." + " Thank you for playing!");
            Console.WriteLine("\n");


        }
    }
}
