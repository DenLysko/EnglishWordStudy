using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishWordStudy
{
    internal class DictionaryElement
    {
        public string? _englishElement;
        public List<string> _russianTranslations;

        public int? _correctAnswersCounter;

        public DictionaryElement(string? englishElement, List<string> russianTranslartions, int correctAnswerCounter = 0)
        {
            _englishElement = englishElement;
            _russianTranslations = russianTranslartions;
            _correctAnswersCounter = correctAnswerCounter;
        }

        public List<string> GetRussianTranslations()
        {
            return _russianTranslations;
        }

        public string? GetEnglishElement()
        {
            return _englishElement;
        }
    }
}
