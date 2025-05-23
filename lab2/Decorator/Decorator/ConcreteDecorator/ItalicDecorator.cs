using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
     class ItalicDecorator : TextDecorator
    {
        public ItalicDecorator(IText innerText) : base(innerText)
        {
        }

        public override string Redaction()
        {
            return $"<i>{_innerText.Redaction()}</i>";
        }
    }
}
