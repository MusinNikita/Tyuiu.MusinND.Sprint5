using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MusinND.Sprint5.Task3.V18.Lib
{
    public class DataService : ISprint5Task3V18
    {
        public string SaveToFileTextData(int x)
        {
            // Выражение F(x) = 2.12 * x^3 + 1.05 * x^2 + 4.1 * x * 2
            double result = 2.12 * Math.Pow(x, 3) + 1.05 * Math.Pow(x, 2) + 4.1 * x * 2;

            // Округляем результат до 3 знаков после запятой
            result = Math.Round(result, 3);

            // Генерируем путь к временному файлу
            string filePath = Path.GetTempPath() + "OutPutFileTask3.bin";

            // Преобразуем результат в бинарный вид
            byte[] binaryResult = BitConverter.GetBytes(result);

            // Записываем бинарные данные в файл
            File.WriteAllBytes(filePath, binaryResult);

            // Выводим результат на консоль
            Console.WriteLine($"Результат вычисления F({x}) = {result}");

            // Возвращаем путь к файлу
            return filePath;
        }
    }
}
