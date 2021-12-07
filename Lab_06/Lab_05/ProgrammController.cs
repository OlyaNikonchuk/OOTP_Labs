using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_05
{

    public struct Date
    {
        public int month;
        public int year;

        public Date(int Month, int Year)
        {
            month = Month;
            year = Year;


        }
    }

    public class ProgrammController : ProgrammAdContainer
    {
        public static int Count = 0;
        public void SearchFilm(Date datA)
        {
            foreach (TVProgramm elem in TVPeredacha)
            {
                if (elem.Date.Equals(datA)) ;
                Console.WriteLine("Cовпадение найдены " + elem.NameOfProgramm);
            }
        }
        public int CountOfRoliks()
        {
            Console.WriteLine("\nчисло рекламных роликов: " + TVPeredacha.Count);
            return TVPeredacha.Count;
        }
        public int CountTimeImba(int time)
        {
            int result = 0;
            result = time * TVPeredacha.Count;
            Console.WriteLine("Общее время длительности программы, учитывая, что вы, милорд сами указываете ее время  в минутах : " + result);
            return result;
        }
    }
}