// リスト10-15 ~ 10-16

using System;

namespace ClassSample{
    class Program{
        static void Main(string[] arg){
            Console.WriteLine("名前を入力してください．");
            var name = Console.ReadLine();
            var mypet = new VirtualPet(name);
            Console.WriteLine($"Name: {mypet.Name}");
            Console.WriteLine($"Mood: {mypet.Mood}");
            Console.WriteLine($"Energy: {mypet.Energy}");
        }
    }

    class VirtualPet{
        // ペットの名前
        public string Name{get; set;}
        // ペットの機能を示す(値が大きいと機嫌が良い)
        public int Mood{get; set;}
        // ペットの元気度を示す(エネルギーの値で元気かどうかを判断)
        public int Energy{get; set;}

        // コンストラクタの定義
        public VirtualPet(string name){
            Name = name;
            Mood = 5;
            Energy = 100;
        }
    }
}