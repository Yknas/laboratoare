using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class VpnConnection : IVpnConnection
    {
        //adresa si portul serverului VPN la care se conecteaza dispozitivul 
        public string ServerAddress {  get; set; }
        public int Port { get; set; }   
        public string ConnectionStatus {  get; set; }

        public VpnConnection(string serverAddress, int port) 
        { 
           ServerAddress = serverAddress;
            Port = port;
            //initial conexiunea nu este stabilita
            ConnectionStatus = "Deconected";
        }

        public void Connect()
        {
            Console.WriteLine($"Connecting to VPN server at {ServerAddress}:{Port}...");
            ConnectionStatus = "Connected";  // conectare simulata 
        }

        public void Disconnect()
        {

            Console.WriteLine($"Disconnecting from {ServerAddress}:{Port}...");
            ConnectionStatus = "Disconnected"; // deconectare simulata
        }
    }
}
