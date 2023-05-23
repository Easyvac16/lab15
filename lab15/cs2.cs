namespace lab15
{
    internal class cs2
    {
        public static void task_2()
        {
            Console.WriteLine("Введіть шлях до оригінального файлу:");
            string sourceFilePath = "C:\\Users\\gdima\\source\\repos\\lab15\\lab15\\cs2\\file_move\\Move.txt";

            Console.WriteLine("Введіть шлях, куди потрібно перемістити файл:");
            string destinationFilePath = "C:\\Users\\gdima\\source\\repos\\lab15\\lab15\\cs2\\file_move2\\Move1.txt";

            try
            {
                if (File.Exists(destinationFilePath))
                {
                    Console.WriteLine("Файл з таким самим ім'ям вже існує у шляху призначення.");
                    Console.WriteLine("Видалення існуючого файлу...");
                    File.Delete(destinationFilePath);
                }

                File.Move(sourceFilePath, destinationFilePath);
                Console.WriteLine("Файл успішно переміщено.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка під час переміщення файлу: " + ex.Message);
            }
        }
    }
}
