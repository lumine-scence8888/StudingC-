using System;
namespace Test
{
	public partial class ParcialClass
	{
		partial void Func(){
			Console.Write("分割メソッドはどっかしらで宣言する。");
		}
	}
}
