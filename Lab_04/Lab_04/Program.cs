using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Set set = new Set("SYO",1);
            set.AddItem("-9");
            set.AddItem("-5");

            Set set2 = new Set("BEI" ,2);
            set2.AddItem("-9");
            set2.AddItem("0");
            set2.AddItem("6");
            set2.AddItem("-5");

            Set set3 = new Set("LIO",3);
            set3.AddItem("-5");
            set3.AddItem("0");

            Set set4 = new Set("KPF",4);
            set4.AddItem("-3");
            set4.AddItem("0");
            set4.AddItem("6");


            Console.WriteLine("--------- Перегрузка оператора * ------------");
            set2 = set2 * set;
            set2.Show();

            Console.WriteLine("--------- Перегрузка оператора > ----------------");
            Console.WriteLine(set > set2);

            Console.WriteLine("--------- Перегрузка оператора < ----------------");
            Console.WriteLine(set < set2);


            Console.WriteLine("---------------------------------------------");

            string a = "awd1 fseo6  ajes";
            int result = 0;

            bool success = int.TryParse(new string(a
                                 .SkipWhile(x => !char.IsDigit(x))
                                 .TakeWhile(x => char.IsDigit(x))
                                 .ToArray()), out result);
            Console.WriteLine($"Это число: {result}");
            Console.WriteLine("---------------------------------------------");

            set4.Show();
            set4.RemoveSpace();
            Console.WriteLine("---------------------------------------------");
            set4.CommaAfterWord();
            set4.Show();
        }
    }
}
