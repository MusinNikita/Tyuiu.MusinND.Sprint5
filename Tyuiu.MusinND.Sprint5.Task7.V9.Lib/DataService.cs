using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MusinND.Sprint5.Task7.V9.Lib
{
    public class DataService : ISprint5Task7V9
    {
        public string LoadDataAndSave(string path)
        {
            // Читаем весь текст из файла
            string fileContent = File.ReadAllText(path);

            // Фильтруем только те символы, которые не являются заглавными латинскими буквами
            var filteredContent = new string(fileContent.Where(c => !(c >= 'A' && c <= 'Z')).ToArray());

            // Создаем временный файл с результатом
            string tempFilePath = Path.GetTempFileName();

            // Записываем отфильтрованный контент в новый файл
            File.WriteAllText(tempFilePath, filteredContent);

            // Возвращаем путь к новому файлу
            return tempFilePath;
        }
    }
}
