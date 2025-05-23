using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class WordText : IText
    {
        private string _wordText;

        public WordText()
        {}

        public WordText (string wordText)
        {
           _wordText = wordText;
        }
        public string Redaction()
        {
            return _wordText ;
        }
    }
}
