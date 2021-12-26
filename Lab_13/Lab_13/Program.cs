using System;

namespace Lab_13
{
    class Program
    {
        static void Main(string[] args)
        {
            NOVDiskinfo.FreeSpace("C:\\");
            NOVDiskinfo.FileSystem("C:\\");
            NOVDiskinfo.DrivesFullInfo();

            string path = @"C:\Users\Оля\Desktop\2 курс\1 семестр\ООТП\OOTP_Labs\Lab_13\Lab_13";
            NOVDirInfo.FileCount(path);
            NOVDirInfo.CreationTime(path);
            NOVDirInfo.ParentDirectory(path);
            NOVDirInfo.SubdirectoriesCount(path);

            string path2 = @"C:\Users\Оля\Desktop\2 курс\1 семестр\ООТП\OOTP_Labs\Lab_13\Lab_13\Program.cs";
            NOVFileInfo.FullPath(path2);
            NOVFileInfo.BasicFileInfo(path2);
            NOVFileInfo.CreationTime(path2);

            NOVFileManager.InspectDrive(@"C:\Users\Оля\Desktop\2 курс\1 семестр\ООТП\OOTP_Labs");
            NOVFileManager.CopyFiles(@"FOLDER", ".txt");
            NOVFileManager.ArchiveUnarchive();

            Console.WriteLine("Удалить каталоги? 1 - да");
            int key = int.Parse(Console.ReadLine());

            if (key == 1)
            {
                System.IO.Directory.Delete("NOVInspect", true);
                System.IO.Directory.Delete("Unzipped", true);
            }
        }
    }
}