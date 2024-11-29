using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MusinND.Sprint5.Task6.V1.Lib
{
    public class DataService : ISprint5Task6V1
    {
        public int LoadFromDataFile(string path)
        {
            // Читаем все содержимое файла в одну строку
            string fileContent = File.ReadAllText(path);

            // Считаем количество цифр в строке
            int digitCount = 0;

            // Проходим по каждому символу в строке
            foreach (char c in fileContent)
            {
                // Если символ является цифрой, увеличиваем счетчик
                if (char.IsDigit(c))
                {
                    digitCount++;
                }
            }

            // Возвращаем количество цифр
            return digitCount;
        }
    }
}
