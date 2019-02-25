using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Intro()
        {
            //intro statement to user
            Console.Write("Welcome! Please choose an operation:\n[1] Addition\n[2] Subtraction\n[3] Multiplication\n[4] Division\nChoice: ");
        }

        static void Addition()
        {
            //collect input from user. Use TryParse for protection against crashes and conversion failures. If an invalid value is provided, no value will be counted into the variable and will default to 0
            Console.Write("Please enter first number: ");
            int.TryParse(Console.ReadLine(), out int firstNum);
            Console.Write("Please enter second number: ");
            int.TryParse(Console.ReadLine(), out int secondNum);
            //Calculate Result
            int result = firstNum + secondNum;
            Console.WriteLine("Result: " + result);
        }

        static void Subtraction()
        {
            //collect input from user. Use TryParse for protection against crashes and conversion failures. If an invalid value is provided, no value will be counted into the variable and will default to 0
            Console.Write("Please enter first number: ");
            int.TryParse(Console.ReadLine(), out int firstNum);
            Console.Write("Please enter second number: ");
            int.TryParse(Console.ReadLine(), out int secondNum);
            //Calculate Result
            int result = firstNum - secondNum;
            Console.WriteLine("Result: " + result);
        }

        static void Multiplication()
        {
            //collect input from user. Use TryParse for protection against crashes and conversion failures. If an invalid value is provided, no value will be counted into the variable and will default to 0
            Console.Write("Please enter first number: ");
            int.TryParse(Console.ReadLine(), out int firstNum);
            Console.Write("Please enter second number: ");
            int.TryParse(Console.ReadLine(), out int secondNum);
            //Calculate Result
            int result = firstNum * secondNum;
            Console.WriteLine("Result: " + result);
        }

        static void Division()
        {
            //collect input from user. Use TryParse for protection against crashes and conversion failures. If an invalid value is provided, no value will be counted into the variable and will default to 0
            Console.Write("Please enter first number: ");
            int.TryParse(Console.ReadLine(), out int firstNum);
            Console.Write("Please enter second number: ");
            int.TryParse(Console.ReadLine(), out int secondNum);
            //Calculate Result
            //protect against divide by 0 problems resulting from default 0
            if (secondNum == 0) {
                Console.WriteLine("You have attempted to divide by 0, which is impossible.");
            }else
            {
                int result = firstNum * secondNum;
                Console.WriteLine("Result: " + result);
            }
        }

        static void Choice()
        {
            //simple input handling for user choice
            char choice = Console.ReadKey().KeyChar;
            //simple switch statement to handle navigation
            switch (choice){
                case '1': Console.WriteLine("\nChoice: Addition");
                    Addition();
                    Outro();
                    break;
                case '2': Console.WriteLine("\nChoice: Subtraction");
                    Subtraction();
                    Outro();
                    break;
                case '3': Console.WriteLine("\nChoice: Multiplication");
                    Multiplication();
                    Outro();
                    break;
                case '4': Console.WriteLine("\nChoice: Division");
                    Division();
                    Outro();
                    break;
                default:
                    //defence against mistypes/invalid choice
                    Console.WriteLine("\nInvalid input. Please choose again"); Console.Write("Choice: ");
                    Choice();
                    break;
            }
        }

        static void Outro()
        {
            //handle ease of use in executing multiple functions
            Console.WriteLine("Would you like to complete another operation? [y/N]");
            //Unable to use OR (||) operator in if statements for char variables within C#, requiring 2 different statements
            char outroChoice = Console.ReadKey().KeyChar;
            if(outroChoice == 'Y'){
                Intro();
                Choice();
            }
            if(outroChoice == 'y')
            {
                Intro();
                Choice();
            }
        }

        static void Main(string[] args)
        {
            //show intro and present main navigation to user
            Intro();
            Choice();
        }
    }
}
