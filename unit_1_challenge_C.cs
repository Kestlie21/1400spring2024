using System;

public class program
{
	public void Main()
	{
		string[] foods =
		{"pizza", "sushi", "hamburgers", "steak"};
		Console.WriteLine(foods.Length);
		foreach (var food in foods)
		{
			Console.WriteLine("I love " + food + ".");
		}

		Console.Write("Enter the number: ");
		int numLevels = Convert.ToInt32(Console.ReadLine());
		int[] myNumbs =
		{1,2,3,4,5,6,7,8,9,10};
		for (var i = 0; i < myNumbs.Length; i++)
		{
			foreach (var myNumb in myNumbs);
		}

		if (numLevels < 5)
		{
			Console.WriteLine("too low");
		}
		else
		{
			Console.WriteLine("too high");
		}
	}
} 
