using System;
namespace Test2
{
	using Test;
	public class TestAnotherNamespaceNotChild
	{
		public TestAnotherNamespaceNotChild()
		{
			TestBase TB = new TestBase();
			TB.Pub = -1;
			//TB.Pro = -2;
		}
	}
}
