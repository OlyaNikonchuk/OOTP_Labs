using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05
{
    partial class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("-----------Фильм-------------");
            ArtFilm art = new ArtFilm();
            art.ToTV();
            art.Filmed();

            //Console.WriteLine("-----------Кактусы-------------");
            //News cactus = new News();
            //IPot cactus_2 = cactus;
            //cactus_2.ToPlant();
            //cactus.ToPlant();
            //cactus.GetPlants();
            //cactus.Collect();
            //cactus.PutInPot();

            Console.WriteLine("-----------Мультик-------------");
            Cartoon cartoon = new Cartoon();
            cartoon.ToTV();
            cartoon.Filmed();

            Printer printer = new Printer();
            printer.iAmPrinting(cartoon);

            CollectionType<string> obj1 = new CollectionType<string>();
            IGereric<string> a;
            obj1.Add("bye ");
            obj1.Add("adyos ");
            obj1.Add("sayonara ");
            a = obj1;
            a.Show();

            CollectionType<TV> plnt = new CollectionType<TV>();
            plnt.Add(new ArtFilm());
            plnt.Add(new Cartoon());
            plnt.Add(new News());
            plnt.Show();

            Console.WriteLine("\n");
            CollectionType<TV> obj2 = new CollectionType<TV>();
            ParseFile(obj2);
            obj2.Show();

            obj2.WriteFile(obj2);
        }
    }
}
