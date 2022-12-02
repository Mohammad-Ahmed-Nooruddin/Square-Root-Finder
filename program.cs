using System;

public class Test
{
    // The method by which this program takes the square root of a number n.
    
    // x = √n
    // x²= n
    // x² + x = n + x
    // x(x+1) = n + x
    // x = (n + x)/(x + 1)
    // x = (1 + x + (n-1))/(x + 1)
    // x = 1 + (n - 1)/(x + 1)
  
    // √n = 1 + (n - 1)/(1 + √n)
	
	// The function used to take the square root.
	public static double squareRoot(double number, int steps, int currentStep)
	{
		// If the current step is the last step, return the number.
		if(currentStep >= steps)
		{
			return (1 + (number - 1)/(1 + number));
		}
		// If the current step is not the last step, then call this function again.
		else
		{
			double squareRootVariable = squareRoot(number, steps, currentStep + 1);
			return (1 + (number - 1)/(1 + squareRootVariable));
		}
	}
	public static void Main()
	{
		// Declare the variables to be used.
		double number;
		int steps;
		
		// Opening message
		Console.WriteLine("This program tells you the square root of any number to varying levels of accuracy depending on the number of steps taken.");
		
		// Store the number to be divided.
		Console.Write("The number of which you want the square root : ");
		number = Convert.ToDouble(Console.ReadLine());
		
		// Store the amount of steps to be taken.
		Console.Write("The number of steps : ");
		steps = Convert.ToInt32(Console.ReadLine());
		
		// Call the function and display the result.
		Console.WriteLine(Convert.ToString(squareRoot(number, steps, 1)));
	}
}
