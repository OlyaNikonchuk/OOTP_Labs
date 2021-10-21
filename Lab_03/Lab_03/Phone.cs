using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03
{
    partial class Phone
    {
        public readonly int Id;
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Middlename { get; set; }
        public string Adress { get; set; }
        public int World;
        public int City;
        public int Card;
        int balance;

        //Свойства
        public int Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (value > -1000 && value < 100000000)
                    balance = value;
            }
        }


        //Конструктор
        public Phone(string surname ="", string name= "", string middlename = "", string adress="", int card=0, int balance=0, int city=0, int world = 0)
        {
            Id = this.GetHashCode();
            Surname = surname;
            Name = name;
            Middlename = middlename;
            Adress = adress;
            Card = card;
            Balance = balance;
            City = city;
            World = world;
      
        }


        public void PrintInfo()
        {
            Console.WriteLine();
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("ФИО: " + Surname + " " + Name + " " + Middlename);
            Console.WriteLine("Номер карты: " + Card);
            Console.WriteLine("Баланс: " + balance + "$");
            Console.WriteLine("Внутригородские звонки: " + City + " минут");
            Console.WriteLine("Межгородские звонки: " + World + " минут");

        }

        //Методы расчета баланса
        public void Debit(int debit)
        {
            Balance = Balance + debit;
        }

        public void Credit(int credit)
        {
            Balance = Balance - credit;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Surname: {Surname}, Middlename: {Middlename}"+ Card+City+World ; ;
        }
    }
}
