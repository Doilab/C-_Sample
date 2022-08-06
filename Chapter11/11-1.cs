// リスト11-1 ~ 11-2
using System;

namespace ClassSample{
    class Program{
        static void Main(string[] arg){
            var card = new Card('H', 8);
            card.Print();

            if(card.Suit == 'D'){
                Console.WriteLine("ダイヤのカードです．");
            }else{
                Console.WriteLine("ダイヤのカードではありません．");
            }
        }
    }
    struct Card{
        // プロパティ
        public char Suit{get; private set;} // Suitは読み取り専用プロパティ
        public int Number{get; private set;}    // Numberは読み取り専用プロパティ
        
        // コンストラクタ
        public Card(char suit, int number){
            Suit = suit;
            Number = number;
        }

        // メソッド
        public void Print(){
            var s = "";
            switch(Suit){
                case 'H':
                    s = "ハート";
                    break;
                case 'D':
                    s = "ダイヤ";
                    break;
                case 'S':
                    s = "スペード";
                    break;
                case 'C':
                    s = "クラブ";
                    break;
            }
            Console.WriteLine($"{s} {Number}");
        }
    }
}