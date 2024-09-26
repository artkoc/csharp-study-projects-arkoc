/*
Import the System namespace, which contains fundamental classes and base classes 
that define commonly-used value and reference data types, events, event handlers, 
interfaces, attributes, and processing exceptions.
Without this namespace, we'd have to type System.Console for console operations.
*/
using System;

namespace ConsoleApp1  // Defines a namespace to logically organize related classes and prevent naming conflicts.
{
    // This class, Program, is the entry point for the console application.
    public class Program  
    {
        /*
        The Main method is the starting point of the application.
        It takes an array of strings as input arguments (command-line args),
        though they are not used in this specific example.
        */
        public static void Main(string[] args)  
        {
            // A boolean variable indicating whether the user is eligible to vote. (Unused here but may have a purpose in extended logic)
            bool canIVote = true;  

            // Display the largest and smallest values an int type can hold.
            Console.WriteLine("Biggest Integer : {0}", int.MaxValue);  // int.MaxValue gives the largest possible integer value.
            Console.WriteLine("Smallest Integer : {0}", int.MinValue);  // int.MinValue gives the smallest possible integer value.

            // Display the largest and smallest values a long (64-bit integer) can hold.
            Console.WriteLine("Biggest Long : {0}", long.MaxValue);  // long.MaxValue gives the largest possible long value.
            Console.WriteLine("Smallest Long : {0}", long.MinValue);  // long.MinValue gives the smallest possible long value.

            /*
            Declare a decimal variable with a high precision value for Pi.
            Decimals are used for financial and high-precision calculations.
            */
            decimal decPiVal = 3.1421412431231231231231231M;  
            /*
            Declare another decimal variable with a value just over 3.
            Adding two decimal values ensures high-precision arithmetic.
            */
            decimal decBigNum = 3.00000000000000000000000011M;  

            // Display the result of adding two decimal values, demonstrating high-precision arithmetic.
            Console.WriteLine("DEC : PI + bigNum = {0}", decPiVal + decBigNum);  

            // Display the largest possible decimal value.
            Console.WriteLine("Biggest Decimal : {0}", decimal.MaxValue);  // decimal.MaxValue gives the largest possible decimal value.

            // Display the largest possible double value.
            Console.WriteLine("Biggest Double {0}", double.MaxValue);  // double.MaxValue gives the largest possible double value.

            /*
            Declare double variables for Pi and another value slightly over 3.
            Doubles are used for floating-point operations that require large ranges, though less precision than decimal.
            */
            double dblPiVal = 3.1411121212121;
            double dblBigNum = 3.000000000002;

            // Output the result of adding two double values.
            Console.WriteLine("*DBL : PI + bigNum = {0}", dblPiVal + dblBigNum);

            // Display the largest possible float value.
            Console.WriteLine("Biggest Float {0}", float.MaxValue);  // float.MaxValue gives the largest possible float value.

            /*
            Declare float variables for Pi and another number just over 3.
            Floats are single-precision and less precise than doubles or decimals.
            */
            double fltPiVal = 3.141112121212F;  
            double fltBigNum = 3.00000000000F;

            // Output the result of adding two float values, showing the limits of single-precision arithmetic.
            Console.WriteLine("*FLT : PI + bigNum = {0}", fltPiVal + fltBigNum);
        }
    }
}
