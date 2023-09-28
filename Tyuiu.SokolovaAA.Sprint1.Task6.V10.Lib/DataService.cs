using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.SokolovaAA.Sprint1.Task6.V10.Lib
{
    public class DataService : ISprint1Task6V10
    {
        public string DeleteMiddleLetter(string value)
        {
            string[] words = value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            // Разбиваем входную строку на отдельные слова и сохраняем их в массив "words"

            foreach (string word in words)
            {
                // Проверка длины слова
                if (word.Length % 2 != 0)
                {
                    // Если длина слова нечетная, удаляем среднюю букву
                    int middleIndex = word.Length / 2;
                    string modifiedWord = word.Remove(middleIndex, 1);
                    Console.Write(modifiedWord + " ");
                    // Выводим модифицированное слово на консоль
                }
                else
                {
                    Console.Write(word + " ");
                    // Если длина слова четная, выводим слово без изменений
                }
            }

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length % 2 != 0)
                {
                    // Если длина слова нечетная, удаляем среднюю букву
                    int middleIndex = words[i].Length / 2;
                    words[i] = words[i].Remove(middleIndex, 1);
                    // Модифицируем слово в массиве "words"
                }
            }

            return string.Join(" ", words);
            // Объединяем все слова в массиве "words" обратно в строку с пробелами в качестве разделителей
        }
    }
}


