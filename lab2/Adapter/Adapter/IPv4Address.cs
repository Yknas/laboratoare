using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
      public class IPv4Address :IIPAddress
    {
        
        private string _address;

        public IPv4Address()
        {}
        
        public IPv4Address(string address)
        {
            _address = address;
        }
        
        public string GetAddress()
        {
            return _address;
        }

        
    }
}
