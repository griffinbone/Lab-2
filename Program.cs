using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Enter your height in inches: ");
		string userInput = Console.ReadLine();
		int number = int.Parse(userInput);
		return number;
	}
}