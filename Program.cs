using System;

namespace lab2
					
 class Program
{
	static void Main(string []args)
	{
		userInput = 5;
		GetANumber();
		GetANumber();
		DisplaySum();
	}

static int GetANumber() {

	int userInput = 0;
	Console.WriteLine("Please enter a number ");
	userInput=int.Parse(Console.ReadLine());

	return userInput;
}