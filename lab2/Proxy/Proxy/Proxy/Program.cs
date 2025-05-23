using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proxy
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            VpnConnectionProxy vpnProxy = new VpnConnectionProxy("vpn.example.com", 443);

            vpnProxy.Connect();  


            Thread.Sleep(3000);
            vpnProxy.Disconnect();  
        }
    }
}
