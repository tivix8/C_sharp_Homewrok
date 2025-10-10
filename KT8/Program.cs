using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT8 {
    internal class Program {
        static void Main(string[] args)
        {
            Box<int> num = new Box<int>();
            Box<string> string1 = new Box<string>();
            num.Set(15);
            string1.Set("Hello");
            Console.WriteLine($"{num.Get()}, {string1.Get()}");
            int x = 5, y = 10;
            Utils.Swap(ref x, ref y);

            string s1 = "Hello", s2 = "World";
            Utils.Swap(ref s1, ref s2);
            Console.WriteLine($"Числа после Swap: {x}, {y}");
            Console.WriteLine($"Строки после Swap: {s1}, {s2}");

            Pair<int, string> pair = new Pair<int, string>();
            pair.First = 13;
            pair.Second = "Word";
            Console.WriteLine($"Первое значение: {pair.First}, Второе значение: {pair.Second}");

            
        }
    }

    public class Box<T> {
        public T Item;
        public void Set(T Item)
        {
            this.Item = Item;
        }
        public T Get()
        {
            return this.Item;
        }
    }

    class Utils {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }

    class Pair<T1, T2> {
        public T1 First;
        public T2 Second;
    }
}
