using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab15
{
    internal class cs3
    {
        public static void task_3()
        {
            Console.WriteLine("Введіть шлях до початкової папки:");
            string sourceFolderPath = "C:\\Users\\gdima\\source\\repos\\lab15\\lab15\\cs3\\Folder_copy";

            Console.WriteLine("Введіть шлях, куди потрібно скопіювати папку:");
            string destinationFolderPath = "C:\\Users\\gdima\\source\\repos\\lab15\\lab15\\cs3\\Folder_copy1";

            try
            {
                CopyFolder(sourceFolderPath, destinationFolderPath);
                Console.WriteLine("Папку успішно скопійовано.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка під час копіювання папки: " + ex.Message);
            }

        }

        static void CopyFolder(string sourceFolder, string destinationFolder)
        {
            if (!Directory.Exists(destinationFolder))
            {
                Directory.CreateDirectory(destinationFolder);
            }

            string[] files = Directory.GetFiles(sourceFolder);
            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                string destinationFilePath = Path.Combine(destinationFolder, fileName);
                File.Copy(file, destinationFilePath, true);
            }

            string[] folders = Directory.GetDirectories(sourceFolder);
            foreach (string folder in folders)
            {
                string folderName = Path.GetFileName(folder);
                string destinationSubfolderPath = Path.Combine(destinationFolder, folderName);
                CopyFolder(folder, destinationSubfolderPath);
            }
        }
    }
}
