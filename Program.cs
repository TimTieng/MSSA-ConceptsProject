/*
Class: ISTA 220 - Programming Fundamentals in C#
Student: Tim Tieng
Instructor: Christine Lee
Date: 05AUG2020
Description: Individual Work- Create a Console App demonstrating/applying your knowledge so far
Concepts Present: While Loops, For , Switch Statements, Methods, Exception Handling, Access Modifiers
Revised By:
Revised On:
Revisions Made:
*/
using System;

namespace ConceptsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            bool displayMenu = true; //Creating a Bool value to assist with decision flow of the main menu feature
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
            MainMenu();
        }
        private static bool MainMenu()
        {
            Console.WriteLine("Option 1: Simple Fibonacci Sequence");
            Console.WriteLine("Option 2: Number Ladder");
            Console.WriteLine("Option 3: Exit Program");

            string result = Console.ReadLine();

            switch(result) //Demonstrating application of Switch statements. Another approach could be IF-ElseIF statements 
            {
                case "1"://Ensure Case conditions are in String format vs Int
                    SimpleFibonacci();
                    return true;
                    break;
                case "2":
                    NumberLadder();
                    return true;
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Thank You, Come Again Soon!");
                    return false;
                    break;
                default:
                    return true;
            }
        }
        private static void SimpleFibonacci()//Fibonacci sequence = list of numbers that the next value depends on the sum of the last 2 preceding values
        {
            Console.Clear();
            int number1 = 0;
            int number2 = 1;
            int number3;
            //Option Greeting message
            Console.WriteLine("This program prints out numbers in the Fibonacci sequence to a certain value");
            try
            {
                //Prompt User for BackStop
                Console.Write("Enter how many values you want in your Fibonacci Sequence: ");
                int backStop = int.Parse(Console.ReadLine()); //Type Conversion required - String to Int
                Console.Write($"[{number1}] [{number2}] ");

                //Iterate tasks using for loop and "backStop" as for loop condition
                for (int i = 2; i < backStop; i++)//i starting at 2 because we printed out the first two numbers previously
                {
                    number3 = number1 + number2;
                    Console.Write($"[{number3}] ");
                    number1 = number2;
                    number2 = number3;
                }
            }
            catch (FormatException fe)//Used to determine if a letter is used versus a numerical value
            {
                Console.WriteLine($"Error due to: {fe.Message}.");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error due to: {e.Message}");
                Console.ReadLine();
            }
            finally
            {
                FinallyBlock();
            }
        }
        private static void NumberLadder()
        {
            Console.Clear();
            Console.WriteLine("This option prints a the numbers from 0-10 in an ascending, then descending value, a certain amount of times based on your input!");
            try
            {
                Console.Write("Enter how many times you want your number ladder to execute: ");
                int ladderLimit = int.Parse(Console.ReadLine());

                for (int i = 0; i < ladderLimit; i++)//Outer Loop determines how many times the ladder executes
                {
                    for (int j = 0; j <=10; j++)//Loop prints the numbers in an ascending manner from 0-10 (INCREMENT)
                    {
                        Console.WriteLine(j);
                    }
                    for (int x = 10; x >= 0; x--)//loops to print the numbers in a desecending manner from 0-10 (DECREMENT)
                    {
                        Console.WriteLine(x);
                    }
                }
            }
            catch (FormatException fe)
            {
                Console.WriteLine($"Error due to: {fe.Message}");
                Console.ReadLine();
            }
            finally
            {
                FinallyBlock();
            }
        }
        private static void FinallyBlock()
        {
            Console.WriteLine("You will be redirected to the Main Menu");
            Console.ReadKey();
        }
    }
}
/*
References:
1. I used a subscription I pay for, AlgoExpert.IO for the idea to attempt to create a program that prints out the Fibonacci Sequence
2. I used similar code from my previously submitted projects to shape the entire program (Main Menu feature, FinallyBlock() from previous HW assignemnts)
*/