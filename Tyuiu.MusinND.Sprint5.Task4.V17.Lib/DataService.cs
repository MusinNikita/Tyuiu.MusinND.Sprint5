using System;
using System.IO;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MusinND.Sprint5.Task4.V17.Lib
{
    public class DataService : ISprint5Task4V17
    {
        public double LoadFromDataFile(string path)
        {
            try
            {
                // Считываем содержимое файла
                string content = File.ReadAllText(path);

                // Преобразуем строку в вещественное значение
                if (!double.TryParse(content, NumberStyles.Float, CultureInfo.InvariantCulture, out double x))
                {
                    throw new FormatException("Некорректное значение в файле.");
                }

                // Проверка на допустимость значения для функции cos(x)
                if (Math.Cos(x) == 0)
                {
                    throw new DivideByZeroException("Невозможно вычислить значение: деление на 0.");
                }

                // Вычисляем значение по формуле y = (1 / cos(x)) + x^3
                double y = (1 / Math.Cos(x)) + Math.Pow(x, 3);

                // Округляем до трёх знаков после запятой
                y = Math.Round(y, 3);

                // Возвращаем результат
                return y;
            }
            catch (Exception ex)
            {
                // Логирование ошибок или проброс исключений (при необходимости)
                Console.WriteLine($"Ошибка: {ex.Message}");
                throw;
            }
        }
    }
}
