using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05
{
    class Printer
    {
        public static void IAmPrinting(TVProgramm obj)
        {
            Console.WriteLine("Тип объекта " + obj.GetType());
            Console.WriteLine(obj.ToString());

        }
    }
    class Producer : IPeople
    {
        public string Name { get; set; }
        public Producer(string name)
        {
            Name = name;
        }
    }
    abstract public class TVProgramm
    {
        public string NameOfProgramm;
        public Date Date;
        public int Duration;//
        public int ShowsPerDay;
        public static int Count = 0;


        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;

            TVProgramm programm = (TVProgramm)obj;
            return (this.Date.Equals(programm.Date) && this.NameOfProgramm == programm.NameOfProgramm && this.Duration == programm.Duration && this.ShowsPerDay == programm.ShowsPerDay);
        }

        public override string ToString()
        {
            if (String.IsNullOrEmpty(NameOfProgramm))
                return base.ToString();
            return "Название программы; День проведения программы; Продолжительность; Количество повторений в день  " + NameOfProgramm + "\t" + Date.month + "." + Date.year + "\t." + Duration + "\t" + ShowsPerDay + "\t";
        }

        public override int GetHashCode()
        {

            return Count;

        }

        public TVProgramm(string name, int showsPerWeek, Date datee)
        {
            NameOfProgramm = name;
            ShowsPerDay = (showsPerWeek > 0) ? showsPerWeek : 0;
            Date = datee;
            ++Count;
        }
    }
}
