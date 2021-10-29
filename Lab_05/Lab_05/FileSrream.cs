using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05
{
    partial class Program
    {
        public static void ParseFile(CollectionType<TV> objColl)
        {
            using (StreamReader stream = new StreamReader(@"C:\Users\Оля\Desktop\2 курс\1 семестр\ООТП\OOTP_Labs\Lab_05\Lab_05\5_lab.txt"))
            {
                while (stream.ReadLine() is string line)
                {
                    switch (line)
                    {
                        case "Art Film":
                            objColl.Add(new ArtFilm());
                            break;
                        case "News":
                            objColl.Add(new News());
                            break;
                        case "Cartoon":
                            objColl.Add(new Cartoon());
                            break;
                        /*case "Cactus":
                            objColl.Add(new Cactus());
                            break;*/
                    }
                }
            }
        }
    }

    partial class CollectionType<T>
    {
        public void WriteFile(CollectionType<TV> objColl)
        {
            List<TV> res = objColl.list;
            using (StreamWriter write = new StreamWriter(@"C:\Users\Оля\Desktop\2 курс\1 семестр\ООТП\OOTP_Labs\Lab_05\Lab_05\Write.txt"))
            {
                foreach (TV item in res)
                {
                    write.WriteLine(item);
                }
            }
        }
    }
}
