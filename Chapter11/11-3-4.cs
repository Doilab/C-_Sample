// リスト11-11

using System;

namespace ClassSample{
    class Program{
        static void Main(string[] arg){
            var king = new Card(CardSuit.Spade, 4);
            Console.WriteLine($"Suit:{king.Suit}, Number:{king.Number}");
            ChangeToAce(king);
            Console.WriteLine($"Suit:{king.Suit}, Number:{king.Number}");
        }

        private static void ChangeToAce(Card card){
            card.Number = 1;
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