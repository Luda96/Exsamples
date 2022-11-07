
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1************************
            /*
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
            } else if (a == b)
            {
                Console.Write($" значения равны");
            } else
            {
                Console.WriteLine($"a является минимальным значением {a}");
            }
        */
            //Задача 2*********************************
            
            /*
            Console.WriteLine($"Введите 3 числа и мы тебе скажем какое из них большее: ");
            Console.Write($"Введите свое первое число - ");
            int a = int.Parse(Console.ReadLine()!);
            Console.Write($"Введите второе числo - ");
            int b = int.Parse(Console.ReadLine()!);
            Console.Write($"Введите третье числo - ");
            int c = int.Parse(Console.ReadLine()!);
            int i = c;
            if (a>b) 
            {            
                if (a>c) 
                {
                    i = a;
                } 
                else if (b>c) 
                {
                    i = b;
                }
            } 
            Console.WriteLine($"максимальное число = {i}");
            */

            //Задача 3******************************
            /*
            Console.WriteLine($"Введите числo: ");
            int a = int.Parse(Console.ReadLine()!);
            Console.Write($"a является четным значением {a}?\n"); 
            if (a%2 == 0)
            {
                Console.WriteLine($"a является четным :) ");   
            }
            else
            {
                Console.WriteLine($"a является нечетным :( ");
            }
            */
            //Задача 4************************
            
            // Console.WriteLine($"Введите числo: ");
            // int i = int.Parse(Console.ReadLine()!);
            Console.Write($"Введите числo : ");
            int N = int.Parse(Console.ReadLine()!);

            int i = 1;
            while (i <= N)
            {
                if (i%2 == 0)
                {
                Console.Write($" {i} четное число: ");   
                }
                i+=1;
            }
            
        
        
        }  
    }    
}