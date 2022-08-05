// リスト10-24

using System;

namespace ClassSample{
    class Program{
        static void Main(string[] arg){
            var pet = new VirtualPet("エイミー");
            Console.WriteLine(pet.Name);
            Console.WriteLine(pet.Mood);
            Console.WriteLine(pet.Energy);

            var pet2 = new VirtualPet("リサ");
            pet2.Mood = 1;
            pet2.Energy = 1;
            Console.WriteLine(pet2.Name);
            Console.WriteLine(pet2.Mood);
            Console.WriteLine(pet2.Energy);
        }
    }

    class VirtualPet{
        public string Name{get; private set;}
        public int Mood{get; set;} = 5; // プロパティの値を5で初期化
        public int Energy{get; set;} = 100; // プロパティの値を100で初期化

        // コンストラクタ
        public VirtualPet(string name){
            Name = name;
        }
    }
}