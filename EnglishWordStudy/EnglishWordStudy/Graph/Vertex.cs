using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishWordStudy.Graph
{
    public enum LanguageOfWord
    {
        English = 0,
        Russian = 1,
    }
    public class Vertex
    {
        public Vertex(string word, LanguageOfWord language = 0)
        {
            word = word;
            languageOfWord = language;
        }
        public LanguageOfWord languageOfWord;

        //public LanguageOfWord GetLanguageOfWord(Vertex vertex)
        //{
        //    return vertex._languageOfWord;
        //}

        public string word;

        public string[] GetAllTranslations(Vertex vertex)
        {
            // To Do: Написать реализацию метода, который 
            return null;
        }


    }
}
