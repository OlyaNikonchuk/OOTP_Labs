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
            Phone person1 = new Phone("Петров", "Петр", "Петрович", "Беларусская,21", 5499, 98765, 30,15);
            //person1.PrintInfo();
            //person1.Debit(1000);
            //person1.Credit(222);
            person1.PrintInfo();
            Phone person2 = new Phone("Иванов", "Иван", "Иванович", "Беларусская,21", 7777, 36541,59,0);
            person2.PrintInfo();
            Phone person3 = new Phone("Романов", "Петр", "Алексеевич", "Беларусская,21", 1234, 1234567, 240,120);
            person3.PrintInfo();

            Console.WriteLine("________________________________");

            Phone[] arr = new Phone[3];
            arr[0] = new Phone("Петров", "Петр", "Петрович", "Беларусская,21", 5499, 98765, 30, 15);
            arr[1] = new Phone("Иванов", "Иван", "Иванович", "Беларусская,21", 7777, 36541, 59, 0);
            arr[2] = new Phone("Романов", "Петр", "Алексеевич", "Беларусская,21", 1234, 1234567, 240, 120);

            List<Phone> phone = new List<Phone>();


            foreach (Phone el in arr)
            {
                if (el.World > 0)

                el.PrintInfo();

            }
            Console.WriteLine("________________________________");

            int hightPoint;
            Console.WriteLine("Введите границу ");
            hightPoint = Convert.ToInt32(Console.ReadLine());

            foreach (Phone el in arr)
            {
                if (el.City > hightPoint)

                    el.PrintInfo();
                else
                {
                    Console.WriteLine("Таких пользователей нет");
                    break;
                }

            }
        }
    }
}
