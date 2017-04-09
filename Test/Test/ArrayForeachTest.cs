using System;
namespace Test
{
	public class ArrayForeachTest
	{
		//var型配列内は常に同一の型
		public static void Main()
		{
			int[] array = new int[] { 1, 55, 8 };	//一次元配列

			int[,] matrix = new int[,] { {467, 79 }, {5000,8} };    //二次元配列

			int[][] jagggedArray = new int[2][];	//ジャグ配列
			jagggedArray[0] = new int[2];
			jagggedArray[1] = new int[3];

			/*var[][] jagggedArray2 = new int[2][];    //ヴァリアブルのジャグ配列は初期化しないと不可
			jagggedArray2[0] = new int[2];
			jagggedArray2[1] = new int[3];*/




			foreach (var number in array)
			{
				
			}

		}
		public ArrayForeachTest()
		{
		}
	}
}
