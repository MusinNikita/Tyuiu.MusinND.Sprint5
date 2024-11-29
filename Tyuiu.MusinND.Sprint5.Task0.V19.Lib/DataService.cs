using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MusinND.Sprint5.Task0.V19.Lib
{
    public class DataService : ISprint5Task0V19
    {
        public string SaveToFileTextData(int x)
        {
            double underRoot = x * x - 2;
            double numerator = 2 * x * x - 1;
            double denominator = Math.Sqrt(underRoot);
            double result = numerator / denominator;

            // Округляем результат до трех знаков после запятой
            result = Math.Round(result, 3);

            // Сохраняем результат в файл
            string fileName = "OutPutFileTask0.txt";
            File.WriteAllText(fileName, result.ToString());

            // Выводим результат на консоль
            Console.WriteLine($"Результат: {result}");
        }
    }
}
