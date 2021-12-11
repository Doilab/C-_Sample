using System;

namespace MySample{
	class Program{
		static void Main(string[] args){
			Console.WriteLine("ご希望の時間帯の番号を入力してください");
			Console.WriteLine("0:午前中");
			Console.WriteLine("1:14時から16時");
			Console.WriteLine("2:16時から18時");
			Console.WriteLine("3:19時から21時");
			var line = Console.ReadLine();
			var num = int.Parse(line);
			
			switch(num){
				case 0:
					Console.WriteLine("午前中12時までに配達の手配をさせていただきます");
					break;
				case 1:
					Console.WriteLine("14時から16時の間に配達の手配をさせていただきます");
					break;
				case 2:
					Console.WriteLine("16時から18時の間に配達の手配をさせていただきます");
					break;
				case 3:
					Console.WriteLine("19時から21時の間に配達の手配をさせていただきます");
					break;
				default :
					Console.WriteLine("入力された番号に誤りがあります");
					break;
			}
		}
	}
}
