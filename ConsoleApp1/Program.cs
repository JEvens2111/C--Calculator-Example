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
            Console.WriteLine("Please enter first number:");
        }

        static void Choice()
        {
            //simple input handling for user choice
            char choice = Console.ReadKey().KeyChar;
            //simple switch statement to handle navigation
            switch (choice){
                case '1': Console.WriteLine("\nChoice: Addition");
                    break;
                case '2': Console.WriteLine("\nChoice: Subtraction");
                    break;
                case '3': Console.WriteLine("\nChoice: Multiplication");
                    break;
                case '4': Console.WriteLine("\nChoice: Division");
                    break;
                default:
                    Console.WriteLine("\nInvalid input. Please choose again"); Console.Write("Choice: ");
                    Choice();
                    break;
            }
        }

        static void Outro()
        {
            Console.WriteLine("Would you like to complete another operation? [Y/n]");
            char outroChoice = Console.ReadKey().KeyChar;
            switch (outroChoice)
            {
                case 'Y': Intro(); Choice(); break;
                case 'y': Intro(); Choice(); break;
                default: break;
            }
        }

        static void Main(string[] args)
        {
            //run intro sequence seperate from choice to prevent clutter
            Intro();
            Choice();
        }
    }
}
