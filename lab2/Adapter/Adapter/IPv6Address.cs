using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class IPv6Address
    {
        private string _address;

        public IPv6Address(){}

        public IPv6Address(string address)
        {
            _address = address;
        }

        public string GetIPv6Address()
        {
            return _address;  
        }

    }
}
