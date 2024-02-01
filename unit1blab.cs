using System;

public class program
{
	public void Main()
	{
		Console.WriteLine("todays temp is ");
		DoMath(40, 30);
		compare(4, 3);
		grade(30,40);
		grade(60,30);
	}

	public void DoMath(int value, int value2)
	{
		var number = value + value2;
		Console.WriteLine(number);
	}

	public void Intro(int value3, int value4)
	{
		var number = value3 + value4;
	}

	public void compare(int value, int value2)
	{
		if (value > value2)
		{
			Console.WriteLine("too hot, drink water.");
		}
	}

	void grade(int value3, int value4)
	{
		if (value3 >= value4)
		{
			Console.WriteLine("A");
		}
		else
		{
			Console.WriteLine("B");
		}
	}
} 
