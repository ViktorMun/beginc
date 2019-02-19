using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*4.	Написать программу обмена значениями двух переменных:
а) с использованием третьей переменной;
б) *без использования третьей переменной.*/

namespace ChangeVar
{
    class Program
    {

        static void Main(string[] args)
        {
            var first = 1;
            var second = 2;
            var third = 3;
            third = first;
            first = second;
            second = third;
            Console.WriteLine(Convert.ToString(first));
            Console.WriteLine(Convert.ToString(second));

            first = first + second;
            second = second - first;
            second = -second;
            first = first - second;
            Console.WriteLine(Convert.ToString(first));
            Console.WriteLine(Convert.ToString(second));
            Console.ReadLine();
        }
    }
}
