using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03
{

   
    class Program
    {
        static void Main()
        {
            Phone person1 = new Phone("Петров", "Петр", "Петрович", "Беларусская,21", 5499, 98765);
            person1.PrintInfo();
            person1.Debit(1000);
            person1.Credit(222);
            person1.PrintInfo();


        }
    }
}
