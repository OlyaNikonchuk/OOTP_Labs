using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04
{
     public class Owner
    {
        private readonly int id;
        private readonly string name;
        public Owner(string name, int id)
        {
            this.name = name;
            this.id = id;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Имя: {name}, ID: {id}");
        }
    }
}
