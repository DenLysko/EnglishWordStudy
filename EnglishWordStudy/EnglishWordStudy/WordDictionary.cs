using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

using System.Threading.Tasks;

namespace EnglishWordStudy
{
    internal class WordDictionary
    {
        ///// <summary>
        ///// EnglishWord and its translations in Russian
        ///// </summary>
        //public Dictionary<string, List<string>> dicEnRu = new ();

        public List<DictionaryElement> Elements;

        public WordDictionary()
        {
            Elements = new List<DictionaryElement>();
        }

        public List<string> rightRussianAnswers = new ();

        public double completionPercent = 0;

        public void ReadMainDictionary()
        {
            // Берём непосредственно сам txt-шный файл
            var mainDictionaryAsFileInfo = new FileInfo(new DirectoryInfo(".").Parent?.Parent?.Parent?.Parent?.Parent?.FullName + "/MainDictionary.txt");
            var streamReaderForMainDictionary = new StreamReader(mainDictionaryAsFileInfo.FullName);
            var allTextFromMainDictionary = streamReaderForMainDictionary.ReadToEnd();
            //var standartStringsFromMainDictionary = allTextFromMainDictionary.Split('\n');
            FillDictionary(allTextFromMainDictionary.Split('\n'));            
        }

        public void FillDictionary(string[] standartStringsFromMainDictionary)
        {
            foreach (string standartString in standartStringsFromMainDictionary)
            {
                if (string.IsNullOrEmpty(standartString)) 
                    continue;
                
                var splittedStandartString = standartString.Split('-');
                var secondPartOfStandartString = splittedStandartString[1].Trim(' ');
                var splittedSecondPartOfStandartString = secondPartOfStandartString.Split(',').ToList();
                int correctAnswerCounter;
                try
                {
                    // Если получится парсить, то удаляем последний элемент
                    correctAnswerCounter = int.Parse(splittedSecondPartOfStandartString.Last());
                    splittedSecondPartOfStandartString.RemoveAt(splittedSecondPartOfStandartString.Count - 1);
                }
                catch 
                {
                    correctAnswerCounter = 0;
                }
                Elements.Add(new DictionaryElement(splittedStandartString[0].Trim(' '), splittedSecondPartOfStandartString, correctAnswerCounter));

                //var correctAnswerCounter = int.TryParse(splittedSecondPartOfStandartString.Last(), int 0);
                
            }
            //standartStringsFromMainDictionary.Split('\n');
            //for (int i = 0; i < standartStringsFromMainDictionary.Length; i = i + 2)
            //{
            //    dicEnRu[standartStringsFromMainDictionary[i]].Add(standartStringsFromMainDictionary[i + 1]);
            //}
        }
    }
}
