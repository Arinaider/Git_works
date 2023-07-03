using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//С гордостью и надменностью выполнила Гуленок Арина 22ИС
namespace Практическая_работа_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добавление изменений в программу");
            Console.WriteLine("Введите значение х:");
            string s = Console.ReadLine();  
            double x = double.Parse(s);
            double F = 5 * Math.Sin(x) - 7 * Math.Cos(x);
            Console.WriteLine("Значение функции = "+F);
            Console.ReadKey();

        }
    }
}
