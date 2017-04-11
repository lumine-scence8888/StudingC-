using System;
namespace Test
{
	abstract public class AbstractParent
	{
		public AbstractParent()
		{
		}
		protected abstract void Method1();//継承する前提なのでprotectedかpublic
	}
}
