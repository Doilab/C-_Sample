// リスト11-4 ~ 11-7

using System;

namespace ClassSample{
    class Program{
        static void Main(string[] arg){
            var card = new Card(CardSuit.Heart, 8);
            card.Print();

            if(card.Suit == CardSuit.Diamond){
                Console.WriteLine("ダイヤです");
            }else{
                Console.WriteLine("ダイヤではありません");
            }
        }
    }
    // CardSuit列挙型の定義
    enum CardSuit{
        Club = 0,
        Spade = 1,
        Heart = 2,
        Diamond = 3
    }
    // Card 構造体の定義
    struct Card{
        public CardSuit Suit{get; set;}
        public int Number{get; set;}

        public Card(CardSuit suit, int number){
            Suit = suit;
            Number = number;
        }

        public void Print(){
            var s = "";
            switch(Suit){
                case CardSuit.Heart:
                    s = "ハート";
                    break;
                case CardSuit.Diamond:
                    s = "ダイヤ";
                    break;
                case CardSuit.Spade:
                    s = "スペード";
                    break;
                case CardSuit.Club:
                    s = "クラブ";
                    break;
            }
            Console.WriteLine($"{s} {Number}");
        }
    }
}