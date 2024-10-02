// Step 1: Import necessary namespaces
using System;

// Step 2: Define a class called MathOperations
public class MathOperations
{
    // Step 3: Create a void method that takes two integers as parameters
    public void PerformOperation(int firstNumber, int secondNumber)
    {
        // Step 4: Perform a simple math operation (e.g., multiply firstNumber by 2)
        int result = firstNumber * 2;

        // Step 5: Output the secondNumber to the console
        Console.WriteLine("Second number: " + secondNumber);
    }
}

// Step 6: The Main method is the entry point of the program
class Program
{
    static void Main(string[] args)
    {
        // Step 7: Instantiate the MathOperations class
        MathOperations mathOp = new MathOperations();

        // Step 8: Call the method with unnamed parameters (positional)
        mathOp.PerformOperation(10, 20); // Pass 10 and 20 as the two numbers

        // Step 9: Call the method with named parameters
        mathOp.PerformOperation(firstNumber: 5, secondNumber: 15); // Pass 5 and 15 using named parameters

        // Keep the console window open
        Console.ReadLine();
    }
}
