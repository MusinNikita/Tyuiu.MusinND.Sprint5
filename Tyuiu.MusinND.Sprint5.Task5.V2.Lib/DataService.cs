using System;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MusinND.Sprint5.Task5.V2.Lib
{
    public class DataService : ISprint5Task5V2
    {
        public double LoadFromDataFile(string path)
        {
            // Читаем все строки из файла
            string[] lines = File.ReadAllLines(path);

            // Преобразуем строки в массив вещественных чисел
            double[] numbers = lines.Select(line => double.Parse(line.Trim())).ToArray();

            // Отбираем только положительные значения
            var positiveNumbers = numbers.Where(num => num > 0).ToArray();

            // Если есть положительные числа, считаем их среднее
            if (positiveNumbers.Any())
            {
                double average = positiveNumbers.Average();
                // Округляем результат до 3 знаков после запятой
                return Math.Round(average, 3);
            }

            // Если нет положительных чисел, возвращаем 0
            return 0;
        }
    }
}
