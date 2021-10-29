using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05
{
    class Printer
    {
        public void iAmPrinting(TV someobj)
        {
            Console.WriteLine("Тип объекта = " + someobj.ToString());
        }
    }

    abstract class TV
    {
        protected int numOfTV = 0;
        public override string ToString() => "TV";
        public TV() { }
        public virtual void Pour(int litters)
        {
            Console.WriteLine($"Вы полили растение {litters} литрами воды");
        }
        public abstract void ToTV();
        public void GetTv() => Console.WriteLine($"Всего {numOfTV} растеный вида {ToString()}");
    }

    sealed class News : TV
    {
        public override string ToString() => "News";
        public override void ToTV() => Console.WriteLine("Вы включили новости киноиндустрии");

    }

    class Film : TV
    {
        public override string ToString() => "Channel";
        public override void ToTV() => Console.WriteLine("Вы посадили цветок");
        public override bool Equals(object obj)
        {
            if (obj.GetType() != GetType())
                return false;
            Film other = (Film)obj;
            return (numOfTV == other.numOfTV);
        }

        public override int GetHashCode()
        {
            return DateTime.Now.Millisecond;
        }
    }

    class ArtFilm : Film, IProduser
    {
        public override string ToString() => "Art Film";
        public override void ToTV() => Console.WriteLine("Вы включили худ. фильм");
        public void Filmed() => Console.WriteLine("Этот фильм снял Стевен Спилберг ");
    }

    class Cartoon : Film, IProduser
    {
        public override string ToString() => "Cartoon";
        public override void ToTV() => Console.WriteLine("Вы включили мультфильм");
        public void Filmed() => Console.WriteLine("Этот мультфильм снят Хаяо Миядзаки");

          }
    //class Add : Film, IBreak
    //{
    //    public override string ToString() => "Add";
    //    public override void ToTV() => Console.WriteLine("Вы посадили кактус (abstract)");
    //    void IBreak.ToTV() => Console.WriteLine("Вы посадили кактус (interface)");
    //    //public void Collect() => Console.WriteLine("Вы собрали кактус");
    //    public void Product() => Console.WriteLine("Вы поместили кактус в горшок");
    //}
}
