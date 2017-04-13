using System;
namespace Test
{
	public interface InterfaceTest	//インターフェ'イ'ス名をIで始める習慣がある。
	{
		//インターフェイスとは抽象メンバのみ持った参照型。
		string Name{
			get;
			set;
		}

		int Method();


	}

	public interface IInterfaceTest{
		string SubName{
			get;
		}
	}


	public class IT:InterfaceTest, IInterfaceTest	//抽象メンバは全部実装する。
	{
		private string name;
		private string subName;
		public string Name{
			get{
				return name;
			}set{
				name = value;
			}
		}
		public string SubName
		{
			get
			{
				return subName;
			}
		}

		public IT(string name){
			this.name = name;
		}

		public int Method(){
			return 321;
		}

	}
}
