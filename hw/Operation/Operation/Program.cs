using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operation
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 100000;
            var random = new Random();
            int[] mas = new int[size];
            Console.WriteLine("Работает массив");
            for(int i = 0; i < size; i++)
            {
                mas[i] = random.Next(size);
            }
            Console.WriteLine("Массив готов");
            Console.ReadLine();
        }
    }
}
