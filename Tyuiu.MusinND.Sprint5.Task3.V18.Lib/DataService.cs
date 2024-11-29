using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MusinND.Sprint5.Task3.V18.Lib
{
    public class DataService : ISprint5Task3V18
    {
        public byte[] SaveToFileTextData(int x)
        {
            // Выражение F(x) = 2.12 * x^3 + 1.05 * x^2 + 4.1 * x * 2
            double result = 2.12 * Math.Pow(x, 3) + 1.05 * Math.Pow(x, 2) + 4.1 * x * 2;

            // Округляем результат до 3 знаков после запятой
            result = Math.Round(result, 3);

            // Преобразуем результат в массив байтов (формат double в бинарном виде)
            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (BinaryWriter writer = new BinaryWriter(memoryStream))
                {
                    writer.Write(result); // Записываем результат в бинарном формате
                }

                // Возвращаем содержимое в виде массива байтов
                return memoryStream.ToArray();
            }
        }
    }
}
