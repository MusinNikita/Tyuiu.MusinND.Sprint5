using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MusinND.Sprint5.Task1.V10.Lib
{
    public class DataService : ISprint5Task1V10
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string fileName = "OutPutFileTask1.txt";
            string resultMessage = string.Empty;

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                for (int x = startValue; x <= stopValue; x++)
                {
                    double result;

                    // Проверяем деление на ноль
                    if (Math.Abs(2 * x - 1) < 1e-9) // Проверка, близко ли значение к нулю
                    {
                        result = 0;
                    }
                    else
                    {
                        // Вычисляем значение функции
                        result = ((2 * Math.Cos(x) + 2) / (2 * x - 1)) + Math.Cos(x) - 5 * x + 3;
                    }

                    // Округляем результат до двух знаков после запятой
                    result = Math.Round(result, 2);

                    // Записываем результат в файл
                    writer.WriteLine($"x = {x}, F(x) = {result:F2}");

                    // Storing last result as a message for returning
                    resultMessage = $"Last calculated result for x = {x} is F(x) = {result:F2}";
                }
            }

            return resultMessage;
        }
    }
}
