using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MusinND.Sprint5.Task3.V18.Lib
{
    public class DataService : ISprint5Task3V18
    {
        public byte[] SaveToFileTextData(int x)
        {
            // Выражение F(x) = 2.12 * x^3 + 1.05 * x^2 + 4.1 * x * 2
            double result = 2.12 * Math.Pow(x, 3) + 1.05 * Math.Pow(x, 2) + 4.1 * x * 2;

            // Округляем результат до 3 знаков после запятой
            result = Math.Round(result, 3);

            // Генерируем путь к временному файлу
            string filePath = Path.GetTempFileName();

            // Записываем результат в бинарный файл
            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
            {
                writer.Write(result);
            }

            // Читаем содержимое бинарного файла как массив байтов
            byte[] binaryData = File.ReadAllBytes(filePath);

            // Удаляем временный файл
            File.Delete(filePath);

            // Выводим результат на консоль
            Console.WriteLine($"Результат вычисления F({x}) = {result}");
            Console.WriteLine($"Бинарное представление: {BitConverter.ToString(binaryData)}");

            // Возвращаем бинарное содержимое
            return binaryData;
        }
    }
}
