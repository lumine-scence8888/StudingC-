using System;
namespace Test
{
	public class Write
	{
		//コンソール読み書きテスト
		public static void Main()
		{
			int a = 10, b = 20;

			Console.WriteLine(a + " + " + b + " = " + (a + b));

			string str;

			str = Console.ReadLine();
			Console.WriteLine(str);
		}
		public Write()
		{
			
		}
	}
}
