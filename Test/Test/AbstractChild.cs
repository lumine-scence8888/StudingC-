using System;
namespace Test
{
	public class AbstractChild : AbstractParent	//子クラスは抽象クラスではなくても
	{
		public AbstractChild()
		{
		}
		protected override void Method1(){	//継承時、アクセサ修飾子は変更不可
			Console.WriteLine("抽象メソッドは必ずオーバーライド");
		}
	}
}
