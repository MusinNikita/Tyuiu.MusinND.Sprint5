using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MusinND.Sprint5.Task4.V7.Lib
{
    public class DataService : ISprint5Task4V7
    {
        public double LoadFromDataFile(string path)
        {
            // Читаем вещественное число из файла
            string fileContent = File.ReadAllText(path).Trim(); // Убираем лишние пробелы

            // Преобразуем строку в вещественное число
            double x = double.Parse(fileContent);

            // Вычисляем y = (1 / cos(x)) + x^3
            double y = (1 / Math.Cos(x)) + Math.Pow(x, 3);

            // Округляем результат до 3 знаков после запятой
            return Math.Round(y, 3);
        }
    }
}
