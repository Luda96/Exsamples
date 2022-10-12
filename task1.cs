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
        }
    }
}