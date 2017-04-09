using System;
namespace Test
{
	public class TestNotChild
	{
		public TestNotChild()
		{
			TestBase TB = new TestBase();
			TB.Pub = -1;
			//TB.Pro = -2;
		}
	}
}
