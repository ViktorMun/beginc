

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*1.	Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
а) используя склеивание;
б) используя форматированный вывод;
	в) используя вывод со знаком $.*/

namespace Anketa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Имя:");
            string first_name = Console.ReadLine();
            Console.WriteLine("Фамилия:");
            string last_name = Console.ReadLine();
            Console.WriteLine("Возраст:");
            string age = Console.ReadLine();
            Console.WriteLine("Рост:");
            string height = Console.ReadLine();
            Console.WriteLine("Вес:");
            string weight = Console.ReadLine();

            Console.WriteLine("Имя:" + first_name + " " + "Фамилия:" + last_name + " " + "Возраст:" + age + " " + "Рост:" + height + " " + "Вес:" + weight);
            Console.WriteLine("Имя:{0} Фамилия: {1} Возраст:{2} Рост:{3} Вес:{4}", first_name, last_name, age, height, weight);
            Console.WriteLine($"Имя:{first_name} Фамилия:{last_name} Возраст:{age} Рост:{height} Вес:{weight}");
            Console.ReadKey();
        }
    }
}
