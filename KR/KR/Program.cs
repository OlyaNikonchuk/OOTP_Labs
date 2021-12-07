using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR
{
    class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("----------Кортежи---------");
            (int, string, char) crt = (19, "Оля", 'Ж');
            Console.WriteLine("Возраст:   " + crt.Item1);
            Console.WriteLine("Имя:       " + crt.Item2);
            Console.WriteLine("Пол:       " + crt.Item3);

            //Среднее арифметическое
            float n1= -2147483648;
            float n2= 2147483647;
            double n = (n1 + n2) / 2;
            Console.WriteLine("Среденее арифметическое:" +n);

            Console.WriteLine("----------------------------");

            MyString str = new MyString("Hello world");
            str.GetInfo();

            string str1 = "Hello world";

            str1.Vivod();
            str1.Symb();
            str1.Size();
        }

    }
}
