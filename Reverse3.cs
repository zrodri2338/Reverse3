using System;

/*
Name: Zulisa Cruz
Date Completed: July 2026
Description: This program displays three integers, passes them
by reference to a method, and reverses the first and last values.
Resources Used: Course materials and class notes.
*/

namespace Reverse3
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInt = 10;
            int middleInt = 20;
            int lastInt = 30;

            Console.WriteLine("Before reversing:");
            Console.WriteLine($"First: {firstInt}");
            Console.WriteLine($"Middle: {middleInt}");
            Console.WriteLine($"Last: {lastInt}");

            ReverseValues(ref firstInt, ref middleInt, ref lastInt);

            Console.WriteLine("\nAfter reversing:");
            Console.WriteLine($"First: {firstInt}");
            Console.WriteLine($"Middle: {middleInt}");
            Console.WriteLine($"Last: {lastInt}");
        }

        static void ReverseValues(
            ref int firstInt,
            ref int middleInt,
            ref int lastInt)
        {
            int temporaryValue = firstInt;

            firstInt = lastInt;
            lastInt = temporaryValue;
        }
    }
}