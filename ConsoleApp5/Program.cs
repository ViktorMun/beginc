using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class PrintPause
    {
        static void Print(string first_name, string last_name, string city)
        {
            Console.WriteLine($"{first_name} {last_name} {city}");
        }
        static void Pause(string[] args)
        {
            Console.ReadLine();
        }
    }
}
