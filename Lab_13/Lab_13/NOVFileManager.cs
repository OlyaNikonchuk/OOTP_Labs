using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace Lab_13
{
    static class NOVFileManager
    {
        /// прочит список файлов и папок из driveName
        /// созд дир NOVInspect
        /// созд NOVdirinfo.txt, сохр. туда инфу
        /// созд копию файла, переимен его, удалить исх

        public static void InspectDrive(string driveName)
        {
            DirectoryInfo dir = new DirectoryInfo(driveName);
            FileInfo[] file = dir.GetFiles();
            Directory.CreateDirectory(@"NOVInspect");

            using (StreamWriter sw = new StreamWriter(@"NOVInspect\NOVdirinfo.txt"))
            {
                foreach (DirectoryInfo d in dir.GetDirectories())
                    sw.WriteLine(d.Name);

                foreach (FileInfo f in file)
                    sw.WriteLine(f.Name);
            }
            File.Copy(@"NOVInspect\NOVdirinfo.txt", @"NOVInspect\NOVdirinfo_renamed.txt");
            File.Delete(@"NOVInspect\NOVdirinfo.txt");
        }

        /// Созд. еще дир CJAFiles
        /// скопир в него все файлвы с зад. расширением из path
        /// переместить CJAFiles в CJAInspect

        public static void CopyFiles(string path, string ext)
        {
            string dirpath = @"NOVFiles";
            Directory.CreateDirectory(dirpath);
            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] files = di.GetFiles();

            foreach (FileInfo file in files)
            {
                if (file.Extension == ext)
                    file.CopyTo($@"{dirpath}\{file.Name}");
            }
            Directory.Move(@"NOVFiles", @"NOVInspect\NOVFiles");
        }


        /// архив из файлов дирректория CJAFiles
        /// разархив. в другой дирректорий

        public static void ArchiveUnarchive()
        {

            string dirpath = @"NOVInspect\NOVFiles";
            string zippath = @"NOVInspect\NOVFiles.zip";
            string unzippath = @"Unzipped";

            ZipFile.CreateFromDirectory(dirpath, zippath);
            ZipFile.ExtractToDirectory(zippath, unzippath);
        }

    }
}