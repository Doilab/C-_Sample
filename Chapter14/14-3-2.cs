// リスト14-9 ~ 14-12

using System;
using System.Collections.Generic;

namespace Example{
    class Program{
        static void Main(string[] arg){
            // リスト14-9
            var pet1 = new FoodiePet("エイミー");
            var pet2 = new CheerfullPet("クー");
            var pet3 = new SleepyPet("ライアン");
            // リスト14-10
            pet1.Eat();
            pet2.Eat();
            pet3.Eat();
            Console.WriteLine("");
            // リスト14-11
            var pets = new List<VirtualPet>();
            pets.Add(pet1);
            pets.Add(pet2);
            pets.Add(pet3);
            // リスト14-12
            foreach(var pet in pets){
                pet.Eat();
                pet.Play();
                Console.WriteLine($"{pet.Name} 機嫌:{pet.Mood} エネルギー:{pet.Energy}");
            }
            Console.WriteLine("");
        }
    }

    class VirtualPet{
        public string Name{get; set;}
        public int Mood{get; set;}
        public int Energy{get; set;}

        // コンストラクタ
        public VirtualPet(string name){
            Name = name;
            Mood = 5;
            Energy = 100;
        }
        
        public virtual void Eat(){   // virtualキーワードを使っている
            // 中身が空っぽのメソッドを定義
        }

        public virtual void Play(){

        }

        public virtual void Sleep(){

        }
    }

    class FoodiePet : VirtualPet{   // VirtualPetクラスを継承

        public FoodiePet(string name) : base(name){ // baseキーワードで，継承元のコンストラクターを呼び出す

        }

        public override void Eat(){ // overrideを使って上書き定義
            Mood += 3;
            Energy += 5;
            Console.WriteLine("FoodiePet.Eat メソッドが実行されました");
        }

        public override void Play(){    // overrideを使って上書き定義
            Mood -= 1;
            Energy -= 10;
            Console.WriteLine("FoodiePet.Play メソッドが実行されました");
        }

        public override void Sleep(){   // overrideを使って上書き定義
            Mood -= 1;
            Energy += 2;
            Console.WriteLine("FoodiePet.Sleep メソッドが実行されました");
        }
    }

    class CheerfullPet : VirtualPet{
        public CheerfullPet(string name) : base(name){

        }

        public override void Eat(){
            Mood += 0;  // 値は変化しない
            Energy += 5;
            Console.WriteLine("CheerfullPet.Eat メソッドが実行されました");
        }

        public override void Play(){
            Mood += 3;
            Energy -= 10;
            Console.WriteLine("CheerfullPet.Play メソッドが実行されました");
        }

        public override void Sleep(){
            Mood -= 1;
            Energy += 2;
            Console.WriteLine("CheerfullPet.Sleep メソッドが実行されました");
        }
    }

    class SleepyPet : VirtualPet{
        public SleepyPet(string name) : base(name){

        }

        public override void Eat(){
            Mood -= 1;
            Energy += 5;
            Console.WriteLine("SleepyPet.Eat メソッドが実行されました");
        }

        public override void Play(){
            Mood -= 1;
            Energy -= 10;
            Console.WriteLine("SleepyPet.Play メソッドが実行されました");
        }

        public override void Sleep(){
            Mood += 2;
            Energy += 2;
            Console.WriteLine("SleepyPet.Sleep メソッドが実行されました");
        }
    }
}