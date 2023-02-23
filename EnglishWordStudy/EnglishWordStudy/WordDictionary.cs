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

        public void FillDictionary(string[] wordsAndTheirTranslations)
        {
            for (int i = 0; i < wordsAndTheirTranslations.Length; i = i + 2)
            {
                dic[wordsAndTheirTranslations[i]] = wordsAndTheirTranslations[i + 1];
            }
           
        }
    }
}
