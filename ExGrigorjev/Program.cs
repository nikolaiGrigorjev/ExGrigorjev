using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExGrigorjev
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variant 3



            //Ü 1.В заданном массиве действительных чисел найдите разность между максимальным и минимальным числом.

            //Ü 2.В одномерном массиве из K чисел M[] подсчитайте количество элементов, удовлетворяющих условию 0 < M[i] < 125.K, M создаются случайно.

            /*Ü 3.Задача Иосифа.По кругу располагаются п человек.Ведущий считает по кругу, начиная с первого, и выводит(«казнит») m - го человека.
            Круг смыкается, счет возобновляется со следующего после «казненного»; так продолжается, пока «в живых» останется только один человек.
            Найти номер оставшегося «в живых» человека, а также найти такое т > 1, при котором «в живых» останется первый[10].*/

            Console.WriteLine("--------------------------------Nr1------------------------------------------");
            Random rand = new Random();
            int[] number = new int[10];
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = rand.Next(1, 10);
                Console.WriteLine("");
            }
            int max = number.Max();
            int min = number.Min();
            Console.WriteLine("\nMax number = {0}", max);
            Console.WriteLine("\nMinimal Number = {0}", min);
            int minus = max - min;
            Console.WriteLine("\nVahe= " + minus);
            
            
                Console.WriteLine("--------------------------------Nr2------------------------------------------");
                Random rnd = new Random();
                int[] M = new int[100];
                int num = 0;
                for (int i = 0; i < 100; i++)
                {
                    M[i] = rnd.Next(0, 125);
                    if (M[i] > 0 && M[i] < 125) 
                        num++;


                }
                Console.WriteLine(num);
                


            Console.WriteLine("--------------------------------Nr3------------------------------------------");
            Random rann = new Random();
            int[] P = new int[10];
            int kaznit = 0;
            for (int i = 0; i < 10; i++)
            {
                
            }
            Console.ReadLine();

        }
    }
}
