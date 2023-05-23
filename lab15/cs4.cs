using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab15
{
    internal class cs4
    {
        public static void task_4()
        {
            Console.WriteLine("Введіть шлях до оригінальної папки:");
            string sourceFolderPath = "C:\\Users\\gdima\\source\\repos\\lab15\\lab15\\cs4\\Folder_move";

            Console.WriteLine("Введіть шлях, куди потрібно перемістити папку:");
            string destinationFolderPath = "C:\\Users\\gdima\\source\\repos\\lab15\\lab15\\cs4\\Folder_move1";

            try
            {
                MoveFolder(sourceFolderPath, destinationFolderPath);
                Console.WriteLine("Папку успішно переміщено.");
                DeleteContentsOfFolder(sourceFolderPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка під час переміщення папки: " + ex.Message);
            }



        }

        static void MoveFolder(string sourceFolder, string destinationFolder)
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
                File.Move(file, destinationFilePath);
            }

            string[] folders = Directory.GetDirectories(sourceFolder);
            foreach (string folder in folders)
            {
                string folderName = Path.GetFileName(folder);
                string destinationSubfolderPath = Path.Combine(destinationFolder, folderName);
                MoveFolder(folder, destinationSubfolderPath);
            }
            
        }
        static void DeleteContentsOfFolder(string folderPath)
        {
            string[] files = Directory.GetFiles(folderPath);
            foreach (string file in files)
            {
                File.Delete(file);
            }

            string[] folders = Directory.GetDirectories(folderPath);
            foreach (string folder in folders)
            {
                DeleteContentsOfFolder(folder);
                Directory.Delete(folder);
            }
        }
    }
}
