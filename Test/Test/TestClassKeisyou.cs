using System;
namespace Test
{
	public class TestClassKeisyou : TestClassKurasu
	{

		/*public TestClassKeisyou()
		{
			//Console.WriteLine(s);
		}*/
		public TestClassKeisyou(int n) : base(n){
			//追加で行う処理を書く。
			//baseに渡す引数さえ満たせば継承クラス
			//のコンストラクタの引数はそれより多くても良い
		}

		public override void Method1()
		{
			
			Console.WriteLine("オーバーライド");
		}
	}
}
