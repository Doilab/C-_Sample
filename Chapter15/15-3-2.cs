// リスト15-10 ~ 15-11

using System;

namespace Example{
    class Program{
        static void Main(string[] arg){
            var price = GetPrice();
            var discount = (int)(price * 0.01);
            Console.WriteLine($"割引額: {discount}円");
        }

        private static int GetPrice(){
            while(true){    // returnで脱出するまで繰り返す
                Console.WriteLine("金額を入力してください．");
                var line = Console.ReadLine();
                if(int.TryParse(line, out var num)){    // TryParseを使うと例外が発生しない
                    // 変換に成功．変換した値はnumに格納される
                    return num;
                }
                // 変換に失敗．再度繰り返す
                Console.WriteLine("入力に誤りがあります．");
            }
        }
    }
}