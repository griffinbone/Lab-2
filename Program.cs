using System;

namespace lab2
{			
 	class Program
	{
	static void Main(string []args)
		{

			int num1 = GetANumber();
			int num2 = GetANumber();
			DisplaySum(num1, num2);
		}

		static int GetANumber() {

			int userInput = 0;
			Console.WriteLine("Please enter a number ");
			userInput=int.Parse(Console.ReadLine());

			return userInput;

			// Console.WriteLine("Please enter a number");
			// return int.Parse(Console.ReadLine());

		}

		static void DisplaySum(int num1, int num2) {
			Console.WriteLine("The sum is: " + (num1+num2));

		}



	}

}
}


		