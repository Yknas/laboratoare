using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPv4Address ipv4 = new IPv4Address("192.168.1.100");

            IIPAddress adaptedIP = new IPv4ToIPv6Adapter(ipv4);

            Console.WriteLine("IPv6 obtinut: " + adaptedIP.GetAddress());
        }
    }
}
