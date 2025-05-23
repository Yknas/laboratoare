using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class TextDecorator : IText
    {
        //field privat pt ca  clasele derivate tr sa aiba acces camp 
        protected IText _innerText;

        public TextDecorator(IText innerText)
        {
            _innerText = innerText;
        }
        public abstract string Redaction();
       
    }
}
