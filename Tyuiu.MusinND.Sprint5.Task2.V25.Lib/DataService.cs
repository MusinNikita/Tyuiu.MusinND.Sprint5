using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MusinND.Sprint5.Task2.V25.Lib
{
    public class DataService : ISprint5Task2V25
    {
        // Метод для замены нечетных чисел на 0
        public void ReplaceOddNumbersWithZero(ref int[,] matrix)
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
        }

        // Метод для сохранения двумерного массива в CSV файл
        public string SaveToFileTextData(int[,] matrix)
        {
            // Создаем временный файл
            string filePath = Path.GetTempFileName();
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                // Записываем в файл результат
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        sw.Write(matrix[i, j]);

                        // Если не последний элемент в строке, ставим запятую
                        if (j < matrix.GetLength(1) - 1)
                        {
                            sw.Write(",");
                        }
                    }
                    sw.WriteLine(); // Переход на новую строку
                }
            }

            // Возвращаем путь к созданному файлу
            return filePath;
        }

        // Метод для вывода двумерного массива на консоль
        public void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
