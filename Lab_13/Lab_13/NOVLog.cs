using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab_13
{
    static class NOVLog
    {
        public static void AddSign(string utility, string path, string message)
        {
            using (StreamWriter sr = new StreamWriter(@"C:\Users\Оля\Desktop\2 курс\1 семестр\ООТП\OOTP_Labs\Lab_13\Lab_13\NOVLog.txt", true))
            {
                sr.WriteLine($"{utility}: {path}");
                sr.WriteLine($"{message}: {DateTime.Now}");
            }
        }

    }
}