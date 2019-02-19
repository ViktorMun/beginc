using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*5.а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
    б) *Сделать задание, только вывод организовать в центре экрана.
    в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).
  6. Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).*/

namespace InfoShow
{
    class PrintPause
    {
        public static void Print(string first_name, string last_name, string city)
        {
            Console.WriteLine($"{first_name} {last_name} {city}");
        }
        public static void Pause()
        {
            Console.ReadLine();
        }
    }

    class CenterConsole
    {
        public static void CenterCnsl(int a, int b)
        {
            Console.SetCursorPosition(Console.WindowWidth / a, Console.WindowHeight / b);
        }

    }
    class InfoShow
    {
        static void callPrint(string first_name, string last_name, string city)
        {
            Console.WriteLine($"{first_name} {last_name} {city}");
        }
        static void Main(string[] args)
        {
            string first_name = "Viktor";
            string last_name = "Mun";
            string city = "Astana";

            CenterConsole.CenterCnsl(2, 2);
            callPrint(first_name, last_name, city);

            CenterConsole.CenterCnsl(2, 3);
            PrintPause.Print(first_name, last_name, city);
            PrintPause.Pause();
        }
    }
}
