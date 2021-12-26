using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab_13
{
    static class NOVDirInfo
    {
        public static void FileCount(string path)
        {
            Console.WriteLine($"Кол-во файлов в каталоге {path}: {Directory.GetFiles(path).Length}");
            Console.WriteLine();
            NOVLog.AddSign("NOVDirInfo", path, $"Кол-во файлов в каталоге {path}: {Directory.GetFiles(path).Length}");
        }
        public static void CreationTime(string path)
        {
            Console.WriteLine($"Время создания каталога {path}: {Directory.GetCreationTime(path)}");
            Console.WriteLine();
            NOVLog.AddSign("NOVDirInfo", path, $"Время создания каталога {path}: {Directory.GetCreationTime(path)}");
        }
        public static void SubdirectoriesCount(string path)
        {
            Console.WriteLine($"Количество подкаталогов в каталоге {path}: {Directory.GetDirectories(path).Length}");
            Console.WriteLine();
            NOVLog.AddSign("NOVDirInfo", path, $"Количество подкаталогов в каталоге {path}: {Directory.GetDirectories(path).Length}");

        }
        public static void ParentDirectory(string path)
        {
            Console.WriteLine($"Родительский каталог каталога {path}: {Directory.GetParent(path)}");
            Console.WriteLine();
            NOVLog.AddSign("NOVDirInfo", path, $"Родительский каталог каталога {path}: {Directory.GetParent(path)}");
        }
    }
}