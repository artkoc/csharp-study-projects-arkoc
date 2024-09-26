/*
 Import the System namespace, which contains fundamental classes and base classes 
 that define commonly-used value and reference data types, events and event 
 handlers, interfaces, attributes, and processing exceptions.
 Without this namespace, we'd have to type System.Console for console operations.
*/
using System;

namespace ConsoleApp1  // Defines a namespace called ConsoleApp1, a container for the program's classes.
{
    public class Program  // Defines a public class named Program, which contains the main logic of the application.
    {
        public static void Main(string[] args)  // The main entry point of the application; execution starts here.
        {
            // Prompt the user for their name.
            Console.Write("What is your name? ");  

            // Read the user's input from the console and store it in the variable 'name'.
            string name = Console.ReadLine();  

            // Output a greeting message that includes the user's name.
            Console.WriteLine($"Hello {name}");  
        }
    }
}
