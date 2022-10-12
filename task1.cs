// if (Cht0)
// {
//   Console.Write(" является максимальным значением а");
// }
// // else if (Cht1)
// // {
// //   Console.Write($"b = a");  
// // }  
// // else
// // {
// //   Console.Write($"b является максимальным значением b");  
// // }  
// Console.ReadKey();


using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите 2 числа и мы тебе скажем какое из них большее: ");
            Console.Write($"Введите свое первое число - ");
            int a = int.Parse(Console.ReadLine()!);
            Console.Write($"Введите второе числo - ");
            int b = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"первое число = {a}");
        
         if (a>b)
         {
            Console.WriteLine($"a является максимальным значением {a}");
            Console.Write($"b является минимальным значением {b}");
         }
         else if (a == b)
         {
            Console.Write($" значения равны");
         }
         else
         {
           Console.WriteLine($"a является минимальным значением {a}");
           Console.Write($"b является максимальным значением {b}"); 
         }
        }
    }
}