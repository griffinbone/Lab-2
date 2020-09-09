using System;

namespace lab2
{			
 	class Program
	{
	static void Main(string []args)
		{
			GetANumber();
			int userInput = 5;
			GetANumber();
			DisplaySum();
		}

		static int GetANumber() {

			int userInput = 0;
			Console.WriteLine("Please enter a number ");
			userInput=int.Parse(Console.ReadLine());

			return userInput;

			// Console.WriteLine("Please enter a number");
			// return int.Parse(Console.ReadLine());

		}


	}
}

		