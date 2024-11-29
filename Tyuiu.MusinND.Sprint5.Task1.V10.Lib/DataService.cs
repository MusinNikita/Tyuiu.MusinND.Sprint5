using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MusinND.Sprint5.Task1.V10.Lib
{
    public class DataService : ISprint5Task1V10
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            // Создаем временный файл
            string filePath = Path.GetTempFileName();
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                // Заголовок таблицы
                // Мы не будем писать заголовок, так как ожидаем только значения в формате чисел.

                // Проходим по диапазону с шагом 1
                for (int x = startValue; x <= stopValue; x++)
                {
                    double f_x = CalculateFunction(x);

                    // Форматируем результат с запятой
                    string result = f_x.ToString("F2", CultureInfo.InvariantCulture).Replace('.', ',');

                    // Пишем результат в файл
                    sw.WriteLine(result);

                    // Также выводим на консоль
                    Console.WriteLine(result);
                }
            }

            // Возвращаем путь к созданному файлу
            return filePath;
        }

        // Метод для вычисления значения функции F(x)
        private double CalculateFunction(int x)
        {
            try
            {
                // Проверка деления на 0
                double denominator = 2 * x - 1;
                if (denominator == 0)
                {
                    return 0; // Возвращаем 0 при делении на ноль
                }

                // Вычисление значения функции
                double result = ((2 * Math.Cos(x) + 2) / denominator) + Math.Cos(x) - 5 * x + 3;
                return result;
            }
            catch (Exception)
            {
                // В случае любой ошибки возвращаем 0
                return 0;
            }
        }
    }
}
