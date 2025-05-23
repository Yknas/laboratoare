using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
     class Program
    {
        static void Main(string[] args)
        {
            IText wordText = new WordText("Sablon de proiectare");

            wordText = new BoldDecorator(wordText);
            wordText = new ItalicDecorator(wordText);
            wordText = new UnderlineDecorator(wordText);

            Console.WriteLine(wordText.Redaction());


        }
    }
}
