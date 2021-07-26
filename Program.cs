using System;
namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Practice Creating Variables
            // Create a variable (use your best judgment for type) that stores the numberOfCupsOfCoffee that you drink every day.
            var numberOfCupsOfCoffee = 0;
            // Create a variable (use"" your best judgment for type) called fullName and set it equal to your full name.
            var fullName = "Milagro Scardigno";
            // Create a variable (use your best judgment for type) called today and set it equal to today's date.
            Console.WriteLine("Today at: ");
            var today = DateTime.Today;
            // Use Console.WriteLine and your variables, numberOfCupsOfCoffee, fullName, and today, to output all three on one line.
            Console.WriteLine(today + " " + fullName + " drank " + numberOfCupsOfCoffee + " ☕️cups of coffee ☕️.");
            Console.WriteLine("\n");
            Console.WriteLine("Please press enter to continue.");
            Console.ReadLine();
            // Practice Getting Input From the User
            Console.WriteLine("What is your name?: ");
            // Ask the user for their name and store it in a variable named userName.
            var userName = Console.ReadLine();
            // Print out a greeting to the user, using their name.
            Console.WriteLine("Greetings " + userName + "!.");
            // Practice Getting Different Types of Input From the User
            Console.WriteLine("What's your preferred type of food?: ");
            var favoriteTypeOfFood = Console.ReadLine();
            Console.WriteLine("Hmmmmm!, I love " + favoriteTypeOfFood + " food. It's so delicious!!!.");
            Console.WriteLine("\n");
            Console.WriteLine("Now, lets do some math. Press enter to continue: ");
            Console.ReadLine();
            // Ask the user to input two numbers.
            // Get the numbers as strings using Console.ReadLine, store them in variables named firstNumberAsString and secondNumberAsString
            // Converting String Input Into Numbers
            // Convert each string above to a double using double.Parse. Save the first value in a variable named firstOperand and the second value in a variable named secondOperand.
            Console.WriteLine("Pick one number: ");
            var firstNumber = Double.Parse(Console.ReadLine());
            Console.WriteLine("Pick a second number: ");
            var secondNumber = Double.Parse(Console.ReadLine());
            // Doing Math
            var sum = firstNumber + secondNumber;
            // Add the operand variables from above and save the results in a variable named sum.
            Console.Write("The first number and second number added together equals: " + sum + ".");
            Console.WriteLine("\n");
            // Subtract the secondOperand variable from the firstOperand variable and save the results in a variable named difference.
            var difference = firstNumber - secondNumber;
            Console.WriteLine("Substracting the second number  from the first number equals: " + difference);
            // Multiply the operand variables and save the results in a variable named product.
            var multiplication = firstNumber * secondNumber;
            Console.WriteLine("Multiplying the first number by the second number equals: " + multiplication);
            // Divide the firstOperand by the secondOperand and save the results in a variable named quotient.
            var quotient = firstNumber / secondNumber;
            Console.WriteLine("Dividing the first number from the second number equals: " + quotient);
            // Find the remainder when one operand is divided by the other and save the results in a variable named remainder. See this page if you need to learn more about the modulo operator.
            var modulus = firstNumber % secondNumber;
            Console.WriteLine("The remainder number resulting from the division of the first number by the second number is equal to: " + modulus);
        }
    }
}
