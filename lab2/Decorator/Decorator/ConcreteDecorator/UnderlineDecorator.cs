using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
     class UnderlineDecorator:TextDecorator
    {
        public UnderlineDecorator(IText innerText) : base(innerText)
        {
        }

        public override string Redaction()
        {
            return $"<u>{_innerText.Redaction()}</u>";
        }
    }
}
