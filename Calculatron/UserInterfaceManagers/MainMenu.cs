using System;
using System.Collections.Generic;

namespace Calculatron.UserInterfaceManagers
{
    public class MainMenu : IUserInterfaceManager
    {
        public IUserInterfaceManager Execute()
        {
            string title = "Welcome to Calculatron 3000!";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine(" 1) Add two numbers");
            Console.WriteLine(" 2) Subtract  two numbers");
            Console.WriteLine(" 3) Multiply two numbers");
            Console.WriteLine(" 4) Divide two numbers");

            Console.WriteLine(" 0) Exit");

            Console.Write("> _");
            string choice = Console.ReadLine();
            Console.Clear();
            switch (choice)
            {
                case "1":
                    AddNumbers();
                    return this;
                case "2":
                    SubtractNumbers();
                    return this;
                case "3":
                    MultiplyNumbers();
                    return this;
                case "4":
                    DivideNumbers();
                    return this;
                case "0":
                    Console.Clear();
                    Console.WriteLine("Goodbye!");
                    return null;
                default:
                    Console.WriteLine("Invalid Selection");
                    return this;
            }
        }

        private void AddNumbers()
        {
            
            Console.WriteLine("Let's add two numbers! ");
            int firstNumber = GetANumber("first");
            int secondNumber = GetANumber("second");

            int sumNumber = firstNumber + secondNumber;
            

            Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is {sumNumber}!");
            Console.WriteLine("");
            
            Console.WriteLine("Press ENTER to return to the menu..");
            Console.ReadLine();
            Console.Clear();
        }

        private void SubtractNumbers()
        {

            Console.WriteLine("Let's try subtraction! ");
            Console.WriteLine("Let's start with the number you want to subtract from (minuend)..");
            int firstNumber = GetANumber("first");
            Console.WriteLine("Now let's get the number you want to subtract (subtrahend)..");
            int secondNumber = GetANumber("second");

            int diffNumber = firstNumber - secondNumber;


            Console.WriteLine($"The diffence of {firstNumber} and {secondNumber} is {diffNumber}!");
            Console.WriteLine("");

            Console.WriteLine("Press ENTER to return to the menu..");
            Console.ReadLine();
            Console.Clear();
        }

        private void MultiplyNumbers()
        {

            Console.WriteLine("Let's do multiplilcation! ");
            int firstNumber = GetANumber("first");
            int secondNumber = GetANumber("second");

            int prodNumber = firstNumber * secondNumber;


            Console.WriteLine($"The product of {firstNumber} and {secondNumber} is {prodNumber}!");
            Console.WriteLine("");

            Console.WriteLine("Press ENTER to return to the menu..");
            Console.ReadLine();
            Console.Clear();
        }

        private void DivideNumbers()
        {
            int firstNumber;
            int secondNumber = 9;
            Console.WriteLine("Let's try division! ");
            firstNumber = GetANumber("first");
            secondNumber = GetANumber("second");


            try
            {
                double quotientNumber = firstNumber / secondNumber;
                Console.WriteLine($"The quotient of {firstNumber} and {secondNumber} is {quotientNumber}!");
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine($"The quotient of {firstNumber} and {secondNumber} is undefined!");
            }


            
            Console.WriteLine("");

            Console.WriteLine("Press ENTER to return to the menu..");
            Console.ReadLine();
            Console.Clear();
        }

        static int GetANumber(string whichNumber)
        {
            string tmpString = "";
            int aNumber;

            do
            {
                if (tmpString.Contains(" ")) Console.WriteLine("No spaces - just a whole number");
                Console.Write($"Enter the {whichNumber} number: _");
                tmpString = Console.ReadLine();
            } while (!int.TryParse(tmpString, out aNumber) || tmpString.Contains(" "));
            return aNumber;
        }

    }
}

