using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MusinND.Sprint5.Task2.V25.Lib
{
    public class DataService : ISprint5Task2V25
    {
        // Метод для замены нечетных чисел на 0 и возвращения измененной матрицы
        public int[,] ReplaceOddNumbersWithZero(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 != 0) // Если элемент нечетный
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            return matrix; // Возвращаем измененную матрицу
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
                    // Создаем строку для текущей строки матрицы
                    string line = string.Empty;

                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        line += matrix[i, j];

                        // Если не последний элемент в строке, ставим точку с запятой
                        if (j < matrix.GetLength(1) - 1)
                        {
                            line += ";";
                        }
                    }

                    // Записываем строку в файл
                    sw.WriteLine(line);
                }
            }

            // Возвращаем путь к созданному файлу
            return filePath;
        }

        // Метод для вывода массива на консоль с разделителями ";"
        public void PrintMatrixToConsole(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                // Формируем строку с разделителями ";"
                string line = string.Empty;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    line += matrix[i, j];

                    // Если не последний элемент в строке, добавляем точку с запятой
                    if (j < matrix.GetLength(1) - 1)
                    {
                        line += ";";
                    }
                }

                // Выводим строку на консоль
                Console.WriteLine(line);
            }
        }
    }
}
