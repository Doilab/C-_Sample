// リスト14-18 ~ 14-21

using System;
using System.Collections.Generic;

namespace Example{
    class Program{
        static void Main(string[] arg){
            var pets = new List<IVirtualPet>();
            var pet1 = new FoodiePet("エイミー");
            var pet2 = new CheerfullPet("クー");
            var pet3 = new SleepyPet("ライアン");
            pets.Add(pet1);
            pets.Add(pet2);
            pets.Add(pet3);

            foreach(var pet in pets){
                pet.Eat();
                pet.Play();
                Console.WriteLine($"{pet.Name} 機嫌:{pet.Mood} エネルギー:{pet.Energy}");
            }
        }
    }

    interface IVirtualPet{  // interfaceキーワードでインターフェースを定義
        string Name{get;}   // getだけを定義
        int Mood{get; set;}
        int Energy{get; set;}
        void Eat();
        void Play();
        void Sleep();
    }

    class SleepyPet : IVirtualPet{
        public string Name{get; private set;}
        public int Mood{get; set;}
        public int Energy{get; set;}

        public SleepyPet(string name){
            Name = name;
            Mood = 5;
            Energy = 100;
        }

        public void Eat(){
            Mood -= 1;
            Energy += 5;
            Console.WriteLine("SleepyPet.Eat メソッドが実行されました");
        }

        public void Play(){
            Mood -= 1;
            Energy -= 10;
            Console.WriteLine("SleepyPet.Play メソッドが実行されました");
        }

        public void Sleep(){
            Mood += 2;
            Energy += 2;
            Console.WriteLine("SleepyPet.Sleep メソッドが実行されました");
        }
    }

    class FoodiePet : IVirtualPet{
        public string Name{get; private set;}
        public int Mood{get; set;}
        public int Energy{get; set;}

        public FoodiePet(string name){
            Name = name;
            Mood = 5;
            Energy = 100;
        }

        public void Eat(){
            Mood -= 1;
            Energy += 5;
            Console.WriteLine("FoodiePet.Eat メソッドが実行されました");
        }

        public void Play(){
            Mood -= 1;
            Energy -= 10;
            Console.WriteLine("FoodiePet.Play メソッドが実行されました");
        }

        public void Sleep(){
            Mood += 2;
            Energy += 2;
            Console.WriteLine("FoodiePet.Sleep メソッドが実行されました");
        }
    }

    class CheerfullPet : IVirtualPet{
        public string Name{get; private set;}
        public int Mood{get; set;}
        public int Energy{get; set;}

        public CheerfullPet(string name){
            Name = name;
            Mood = 5;
            Energy = 100;
        }

        public void Eat(){
            Mood -= 1;
            Energy += 5;
            Console.WriteLine("CheerfullPet.Eat メソッドが実行されました");
        }

        public void Play(){
            Mood -= 1;
            Energy -= 10;
            Console.WriteLine("CheerfullPet.Play メソッドが実行されました");
        }

        public void Sleep(){
            Mood += 2;
            Energy += 2;
            Console.WriteLine("CheerfullPet.Sleep メソッドが実行されました");
        }
    }
}