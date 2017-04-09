using System;
namespace Test
{
	public class ClassTest
	{
		static int numD = 1;
		private string name = null;

		//プロパティ
		string wakame	//変数wakameにアクセスしようとした時
		{
			get
			{	//ここに命令を書く。
				return name;
			}set 
			{
				name = value;
			}
		}

		public ClassTest()
		{
		}
		public ClassTest(string name)   //名前を設定できるコンストラクタ
		{
			this.name = name;
		}
		public void setName(string name)    //名前を設定するアクセサメソッド
		{
			this.name = name;
		}

		public string GetName() //名前を取得するアクセサメソッド
		{                           //初期化されていない可能性があるため、try-catchすること。
			return name;
		}

		public void ShowName()
		{
			if(name == null)	//nullが入った変数を参照しただけではExceptionじゃないそうです。
								//Javaだとnullを表示した際"null"と表示される
								//c#は何も表示されない
			{
				Console.WriteLine("エラー: 名前が設定されていません");
			}
			else
			{
				Console.WriteLine("名前: " + this.name);
			}
		}

		public static void SetNumberD(int num)
		{
			numD = num;
		}
	}

	class main
	{
		public static void Main()
		{
			ClassTest Mine = new ClassTest("レーヴァテイン");
			ClassTest Yours = new ClassTest("ダーインスレイヴ");
			ClassTest naru = new ClassTest();

			Mine.ShowName();
			Yours.ShowName();
			naru.ShowName();

		}
	}
}