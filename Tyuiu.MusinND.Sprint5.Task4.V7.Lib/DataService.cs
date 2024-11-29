using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MusinND.Sprint5.Task4.V7.Lib
{
    public class DataService : ISprint5Task4V7
    {
        public double LoadFromDataFile(string path)
        {
            try
            {
                // Читаем вещественное число из файла
                string fileContent = File.ReadAllText(path);
                if (!double.TryParse(fileContent, out double x))
                {
                    throw new FormatException("Ошибка: Содержимое файла не является корректным числом.");
                }

                // Вычисляем y = (1 / cos(x)) + x^3
                double y = (1 / Math.Cos(x)) + Math.Pow(x, 3);

                // Округляем результат до 3 знаков после запятой
                y = Math.Round(y, 3);

                // Возвращаем результат
                return y;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Ошибка при обработке файла: {ex.Message}", ex);
            }
        }
    }
}
