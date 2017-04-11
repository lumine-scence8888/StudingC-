using System;
namespace Test
{
	public class TestTestMain
	{
		public TestTestMain()
		{
		}
		public static void Main()
		{
			TestClassKurasu B = new TestClassKurasu();
			TestClassKeisyou C = new TestClassKeisyou(23);
			ParcialClass PC = new ParcialClass();	//別にファイル名が一致してなくても良い
			B.Method1();
			C.Method1();
			Console.WriteLine(B.hight);
			//B.hight = 787;	//アクセッサがない場合そもそもコンパイラが通さない。
		}
	}
}
