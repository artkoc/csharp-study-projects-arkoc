/*
Import the System namespace, which contains fundamental classes and base classes 
that define commonly-used value and reference data types, events and event 
handlers, interfaces, attributes, and processing exceptions.
Without this namespace, we'd have to type System.Console for console operations.
*/
using System;

namespace ConsoleApp1  // Defines a namespace called ConsoleApp1, which organizes related classes.
{
    public class Program  // Defines a public class named Program that contains the application's main logic.
    {
        public static void Main(string[] args)  // The main entry point of the application; execution starts here.
        {
            bool canIVote = true;  // Boolean flag to indicate if the user is eligible to vote.

            // Output the maximum and minimum values that an integer can hold.
            Console.WriteLine("Biggest Integer : {0}", int.MaxValue);  
            Console.WriteLine("Smallest Integer : {0}", int.MinValue);  

            // Output the maximum and minimum values that a long can hold.
            Console.WriteLine("Biggest Long : {0}", long.MaxValue);  
            Console.WriteLine("Smallest Long : {0}", long.MinValue);  

            // Declare a decimal variable for the value of Pi with high precision.
            decimal decPiVal = 3.1421412431231231231231231M;  
            // Declare another decimal variable with a very small value.
            decimal decBigNum = 3.00000000000000000000000011M;  

            // Output the result of adding decPiVal and decBigNum.
            Console.WriteLine("DEC : PI + bigNum = {0}", decPiVal + decBigNum);  
        }
    }
}
