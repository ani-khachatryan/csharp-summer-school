using System;
using System.Threading;

namespace Calculator
{
    public class Program
    {
        private static void Main()
        {
            Help();
            Reset();
        }
        private static void Help()
        {
            Console.WriteLine("Welcome to C# Console Calculator!");
            Console.WriteLine("Feel free to use integers and simple operations such as + - / *");
            Console.WriteLine("Type 'done' when you finish.");
            Console.WriteLine("Type 'clear' to clear the input.");
            Console.WriteLine("Enter your Expression:     (ex. 6+11)");
        }
        private static void Reset()
        {
            Calculator calc = new Calculator();
            Parser parser = new Parser();
            bool first_time = true;

            while(true)
            {
                if (!first_time)
                {
                    if (calc.Error != "no_errors")
                    {
                        Console.WriteLine(calc.Error);
                        Thread.Sleep(2000);
                        return;
                    }
                    else
                        Console.Write(calc.Result);
                }
                string input = Console.ReadLine();
                if ("done" == input)
                    break;
                if("clear"==input)
                {
                    Reset();
                    break;
                }
                Parsed expression = parser.Parse(input);
                calc.Process(expression);
                first_time = false;
            }
            Console.Write("\nThank you for using me!\nEnjoy your day)");
            Thread.Sleep(2000);
        }
    }
}