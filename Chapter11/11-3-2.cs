// リスト11-9

using System;

namespace ClassSample{
    class Program{
        static void Main(string[] arg){
            var cardA = new Card(CardSuit.Spade, 4);
            var cardB = cardA;
            cardA.Number = 12;
            Console.WriteLine($"CardA: Suit:{cardA.Suit}, Number:{cardA.Number}");
            Console.WriteLine($"CardB: Suit:{cardB.Suit}, Number:{cardB.Number}");
        }
    }

    enum CardSuit{
        Club, Spade, Heart, Diamond
    }

    class Card{
        public CardSuit Suit{get; set;}
        public int Number{get; set;}

        public Card(CardSuit suit, int number){
            Suit = suit;
            Number = number;
        }
    }
}

// 参照型の変数を別の変数に代入する場合は・十分な注意が必要．