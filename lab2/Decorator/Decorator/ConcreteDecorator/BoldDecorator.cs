using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class BoldDecorator : TextDecorator
    {
        public BoldDecorator(IText innerText) : base(innerText)
        {
        }

        public override string Redaction()
        {
            return $"<b>{_innerText.Redaction()}</b>";
        }
    }
}
