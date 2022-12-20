using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perefct_task
{
    internal class Program
    {
        static bool Isperefct(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0) sum = sum + i;
            }
            if (sum == number) return true;
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("pls Enter the frist number: ");
            int x = int.Parse(Console.ReadLine());


            Console.WriteLine("pls Enter the second number: ");
            int y = int.Parse(Console.ReadLine());


            for (int i = x; i <= y; i++)
            {
                if (Isperefct(i)) Console.Write("{0},", i);

            }
            Console.ReadKey();


        }
    }
}
