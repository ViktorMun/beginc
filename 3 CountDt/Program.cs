using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*3.	а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.*/

namespace CountDist
{
    class Program
    {
        static double formulaDistance(double x1, double y1, double x2, double y2)
        {
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return r;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Программа расчета расстояния между точками");
            Console.WriteLine("Введите значение х1:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y1:");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение х2:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y2:");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("{0:F2}", formulaDistance(x1, y1, x2, y2));
                        Console.ReadLine();
        }
    }
}
