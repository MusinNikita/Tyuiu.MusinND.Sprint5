using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MusinND.Sprint5.Task2.V25.Lib
{
    public class DataService : ISprint5Task2V25
    {
        // Метод для замены нечетных чисел на 0 и возвращения результата в строковом формате
        public string ReplaceOddNumbersWithZero(int[,] matrix)
        {
            // Преобразуем матрицу в строку с разделителем ";"
            string result = string.Empty;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 != 0) // Если элемент нечетный
                    {
                        matrix[i, j] = 0;
                    }
                }

                // Формируем строку для текущей строки матрицы с разделителями ";"
                string line = string.Join(";", matrix.GetRow(i));

                // Добавляем строку с переводом на новую строку
                result += line + "\n";
            }

            return result.Trim(); // Убираем лишний перевод строки в конце
        }

        // Метод для сохранения двумерного массива в CSV файл с разделителем ";"
        public string SaveToFileTextData(int[,] matrix)
        {
            // Создаем временный файл
            string filePath = Path.GetTempFileName();

            // Используем StreamWriter для записи в файл
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                // Записываем в файл результат
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    // Формируем строку для текущей строки матрицы с разделителями ";"
                    string line = string.Join(";", matrix.GetRow(i));
                    sw.WriteLine(line);
                }
            }

            return filePath;
        }

        // Метод для вывода массива на консоль с разделителями ";"
        public void PrintMatrixToConsole(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                // Формируем строку с разделителями ";"
                string line = string.Join(";", matrix.GetRow(i));
                Console.WriteLine(line); // Выводим строку на консоль
            }
        }
    }

    // Метод расширения для работы с массивом
    public static class ArrayExtensions
    {
        public static int[] GetRow(this int[,] matrix, int rowIndex)
        {
            int columns = matrix.GetLength(1);
            int[] row = new int[columns];

            for (int i = 0; i < columns; i++)
            {
                row[i] = matrix[rowIndex, i];
            }

            return row;
        }
    }
}
