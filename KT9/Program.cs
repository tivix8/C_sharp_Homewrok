using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT9 {
    internal class Program {
        unsafe static void Main(string[] args)
        {
            

            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine($"До {string.Join(" ", arr)}");

            fixed (int* ptr = arr) 
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    
                    *(ptr + i) += 10;
                    
                }
                
            }
            Console.WriteLine($"После {string.Join(" ", arr)}");

            int x = 50;
            int* p = &x;
            int** pp = &p;
            
            Console.WriteLine($"Адрес x: {(ulong)&x}");
            Console.WriteLine($"Адрес p: {(ulong)p}");
            Console.WriteLine($"Значение x до: {*p}");
            **pp = 999;
            Console.WriteLine($"Значение x после изменения через **pp: {**pp}");
            



        }
    }
}
