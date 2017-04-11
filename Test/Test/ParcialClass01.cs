using System;
namespace Test
{
	public partial class ParcialClass   //別にファイル名が一致してなくても良い
	{
		int member01;
		public ParcialClass()
		{
			member01 = 7667;
		}
		partial void Func();
	}
}
