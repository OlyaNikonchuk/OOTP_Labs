using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Lab_05
{
    class main
    {
        static void Main(string[] args)
        {
            FileLogger fileLogger = new FileLogger();
            ConsoleLogger consoleLogger = new ConsoleLogger();
            try
            {
                ProgrammController Container = new ProgrammController();
                Ads advert = new Ads("Vasya", 14, new Date(11, 2021), "MoiDoDir");
                Ads advertaA = new Ads("Vasssssssssssssssssssssssssssssssssssssssssssssssssssss", 10, new Date(11, 2021), "MoiDoDir");

                Cartoons carton = new Cartoons("Bodya", 14, new Date(11, 2021), "Basnya", "Betrayal");
                ArtisticFilm artist1 = new ArtisticFilm("Sasha", 88, new Date(11, 2021), "Folklor", "DeadIsland", new string[] { "Semis" });
                Console.WriteLine(advert.ToString());
                Console.WriteLine(carton.ToString());
                Console.WriteLine(artist1.ToString());
                Container.Add(advert);
                Container.Add(carton);
                Container.Add(artist1);
                Container.CountOfRoliks();
                Container.CountTimeImba(15);
                Container.SearchFilm(new Date(16, 2021));

                //////////////////////
                ///
            }
            catch (Exceptions ex)
            {
                fileLogger.WriteLog(ex);
            }
            //catch (NameExceptions ex)
            //{
            //    Console.WriteLine("Ошибка : " + ex.Message);
            //}
            //catch (DateExceptions ex)
            //{
            //    Console.WriteLine("Ошибка : "+ex.Message);
            //}
            //catch (CountExceptions ex)
            //{
            //    Console.WriteLine("Ошибка : " + ex.Message);
            //}
            //catch (Exceptions ex)
            //{
            //    Console.WriteLine("Ошибка : " + ex.Message);
            //}
            finally { }
        }


    }
}