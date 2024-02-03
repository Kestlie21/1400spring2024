using System;

public class program
{
	public void Main()
	{
		Console.WriteLine("Your speed is ");
		speed(40, 60);
		compare(4, 3);
		grade(30, 40);
		grade(60, 30);
	}

	public void speed(int value, int value2)
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
			Console.WriteLine("GOING TO FAST, SLOW DOWN");
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

public class sequence
{
	public BirthMonth birthMonth;
	public void secondary()
	{
		birthMonth = new BirthMonth();
		birthMonth.CheckMonth();
	}

	public class BirthMonth
	{
		public enum Month
		{
			January,
			Febuary,
			March,
			April,
			May,
			June,
			July,
			August,
			October,
			September,
			November,
			December
		}

		public Month currentMonth = Month.January;
		public void CheckMonth()
		{
			switch (currentMonth)
			{
				case Month.January:
					Console.WriteLine("January");
					break;
				case Month.Febuary:
					Console.WriteLine("Febuary");
					break;
				case Month.March:
					Console.WriteLine("March");
					break;
				case Month.April:
					Console.WriteLine("April");
					break;
				case Month.May:
					Console.WriteLine("May");
					break;
				case Month.June:
					Console.WriteLine("June");
					break;
				case Month.July:
					Console.WriteLine("July");
					break;
				case Month.August:
					Console.WriteLine("August");
					break;
				case Month.September:
					Console.WriteLine("September");
					break;
				case Month.October:
					Console.WriteLine("October");
					break;
				case Month.November:
					Console.WriteLine("November");
					break;
				case Month.December:
					Console.WriteLine("December");
					break;
			}
		}
	}
}
