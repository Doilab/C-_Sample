// リスト11-10

using System;

namespace ClassSample{
    class Program{
        static void Main(string[] arg){
            var king = new Card(CardSuit.Spade, 13);
            Console.WriteLine($"Suit:{king.Suit}, Number:{king.Number}");
            ChangeToAce(king);  // ChangeToAce メソッドにCardオブジェクトを渡し，メソッド内でCardオブジェクトのプロパティを変更する

            Console.WriteLine($"Suit:{king.Suit}, Number:{king.Number}");
        }

        private static void ChangeToAce(Card card){ // 構造体(値型)を受け取るメソッド
            card.Number = 1;    // 構造体オブジェクトの値を変更
        }
    }

    enum CardSuit{
        Club, Spade, Heart, Diamond
    }

    struct Card{    // Cardは構造体(値型)
        public CardSuit Suit{get; set;}
        public int Number{get; set;}

        public Card(CardSuit suit, int number){
            Suit = suit;
            Number = number;
        }
    }
}