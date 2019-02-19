using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*2.	Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.*/

namespace IndexMT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа расчета индекса массы тела");
            Console.WriteLine("Введите ваш рост в метрах:");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ваш вес в килограммах:");
            double h = Convert.ToDouble(Console.ReadLine());
            double l = m / (h * h); 

            Console.WriteLine($"Ваш индекс массы тела: {l}");

            string weight = Console.ReadLine();
        }
    }
}
