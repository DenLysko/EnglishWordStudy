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
        public Dictionary<string, string> dic = new Dictionary<string, string>();

        public double completionPercent = 0;

        public void ReadMainDictionary()
        {
            // Берём непосредственно сам txt-шный файл
            var mainDictionaryAsFileInfo = new FileInfo(new DirectoryInfo(".").Parent.Parent.Parent.Parent.Parent.FullName + "/MainDictionary.txt");
            var b = new StreamReader(mainDictionaryAsFileInfo.FullName);
            var c = b.ReadToEnd();
            FillDictionary(c.Split('\n'));
            //string[] wordsAndTheirTranslations = c.Split('\n');
            //var d = wordsAndTheirTranslations.Length;




            //string s = mainDictionaryAsTXT

            //var directoryInfo = new DirectoryInfo(".");
            //var a = directoryInfo.FullName;
            //var directoryInfo1 = new DirectoryInfo(directoryInfo.Parent.Parent.Parent.Parent.Parent.FullName);
            //var file = new FileInfo(directoryInfo1 + "/MainDictionary.txt");
            
        }

        public void FillDictionary(string[] wordsAndTheirTranslations)
        {
            for (int i = 0; i < wordsAndTheirTranslations.Length; i = i + 2)
            {
                dic[wordsAndTheirTranslations[i]] = wordsAndTheirTranslations[i + 1];
            }
        }
    }
}
