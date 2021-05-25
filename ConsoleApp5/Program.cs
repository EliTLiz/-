
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int n = int.Parse(Console.ReadLine());
            string[] arr = new string[n];
            Console.WriteLine("Вводите элементы массива массива нажимая Enter");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Console.ReadLine(); // заполнение массива
            }
            Console.WriteLine("Массив: ");
            foreach (string s in arr) Console.Write(s + " "); // вывод массива
            Console.ReadLine();
        }
    }
}
