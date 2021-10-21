using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03
{
    partial class Phone
    {
        int Id=0;
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Middlename { get; set; }
        public string Adress { get; set; }
        public int Card;
        int balance;

        public int Balance
        {
            get 
            {
                return balance;
            }
            set
            {
                if (value<0 && value > 100000000)
                {
                    Console.WriteLine("Ошибка баланса");
                }
                else
                {
                    balance = value;
                }
            }

        }

        

        public Phone(string surname ="", string name= "", string middlename = "", string adress="", int card=0, int balance=0 )
        {
            ++Id;
            Surname = surname;
            Name = name;
            Middlename = middlename;
            Adress = adress;
            Card = card;
            Balance = balance;
        }

        public void PrintInfo()
        {
            Console.WriteLine();
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("ФИО: " + Surname + " " + Name + " " + Middlename);
            Console.WriteLine("Номер карты: " + Card);
            Console.WriteLine("Баланс: " + balance + "$");
            
        }

        public void Debit(int debit)
        {
            Balance = Balance + debit;
        }

        public void Credit(int credit)
        {
            Balance = Balance - credit;
        }
    }
}
