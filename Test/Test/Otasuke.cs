using System;
namespace Test
{
	public class Otasuke
	{
		static int S = 10;
		public static void Main()
		{
			int[] counter = new int[10];
			double scan;
			do{
				scan = double.Parse(Console.ReadLine());
				if (scan >= 0 && scan < S)
				{
					counter[(int)scan]++;
				}
			} while (scan >= 0);
			for (int i = 0; i < S; i++)
			{
				Console.Write(i + ": ");
				draw(counter[i]);
				Console.WriteLine("");
			}
		}

		static void draw(int count)
		{
			for (int i = 0; i < count; i++)
			{
				Console.Write("*");
			}
		}
	}
}
