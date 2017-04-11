using System;
namespace Test
{
	public class TestClassKurasu
	{
		string s = "基本";
		public TestClassKurasu()
		{
			Console.WriteLine(s);
		}
		public TestClassKurasu(int n){
			Console.WriteLine(n);
		}
		private int h = 323;
		public int hight
		{
			get
			{
				return h;
			}
			/*set	//どっちかのアクセサを書かなくても良い。アクセッサメソッドの必要性がなくなる。
			{
				h = value;
			}*/
		}

		public virtual void Method1()
		{
			Console.WriteLine("ベースメソッド");
		}
	}
}
