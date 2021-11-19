using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05
{
    class main
    {
        static void Main(string[] args)
        {
            Object obj = new Ads("Vova", 4, "irL");
            Ads advert = new Ads("Vasya", 14, "MoiDoDir ");
            News novost1 = new News("Anna", 15, "Pogorina", new string[] { "Eurovision" });
            News novost2 = new News("Elena", 13, "Anytina", new string[] { "Belbet" });
            Cartoons carton = new Cartoons("Bodya", 14, "Basnya", "Betrayal");
            ArtisticFilm artist1 = new ArtisticFilm("Sasha", 88, "Folklor", "DeadIsland", new string[] { "Semis" });
            Console.WriteLine(advert.ToString());
            Console.WriteLine(novost1.ToString());
            Console.WriteLine(novost2.ToString());
            Console.WriteLine(carton.ToString());
            Console.WriteLine(artist1.ToString());
            Console.WriteLine(carton as Film);
            Console.WriteLine(advert as TVProgramm);

            Console.WriteLine("------------------------");

            Console.WriteLine(obj is Ads);
            Console.WriteLine(advert is News);
            Console.WriteLine(carton is News);
            Console.WriteLine(advert is IPeople);

            Console.WriteLine("------------------------");
            
            TVProgramm[] array = new TVProgramm[4];
            array[0] = carton;
            array[1] = advert;
            array[2] = novost1;
            array[3] = novost2;

            foreach (var tvProgramm in array)
            {
                Printer.IAmPrinting(tvProgramm);
            }
        }
    }
}
