using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class IPv4ToIPv6Adapter : IIPAddress
    {
        private readonly IPv6Address _ipv6Address = new IPv6Address();
        private IPv4Address ipv4;

        public IPv4ToIPv6Adapter(IPv6Address ipv6Address)
        {
            _ipv6Address = ipv6Address;
        }

        public IPv4ToIPv6Adapter(IPv4Address ipv4)
        {
            this.ipv4 = ipv4;
        }

        public string GetAddress()
        {
            return "::ffff:" + ipv4.GetAddress();
        }
    }
}
