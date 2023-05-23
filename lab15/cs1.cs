namespace lab15
{
    internal class cs1
    {
        public static void task_1()
        {
            Console.WriteLine("Введіть шлях до оригінального файлу:");
            string sourceFilePath = "C:\\Users\\gdima\\source\\repos\\lab15\\lab15\\cs1\\file_copy\\TXT.txt";

            Console.WriteLine("Введіть шлях, куди потрібно скопіювати файл:");
            string destinationFilePath = "C:\\Users\\gdima\\source\\repos\\lab15\\lab15\\cs1\\file_copy1\\TXT1.txt";
            try
            {
                File.Copy(sourceFilePath, destinationFilePath, true);
                Console.WriteLine("Файл успішно скопійовано.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка під час копіювання файлу: " + ex.Message);
            }



        }
    }
}
