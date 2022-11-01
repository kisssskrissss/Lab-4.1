using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи n");
            int N= Convert.ToInt32(Console.ReadLine());
            int s = 1;
            for (int i = 1; i < 2*N -1; i+=2)
            {
                s += 2;
                Console.WriteLine(" Сумма {0}", i);
                s = s + i;
            }
            Console.WriteLine("Квадрат числа {0}", s);
            Console.ReadKey();
        }
    }
}
