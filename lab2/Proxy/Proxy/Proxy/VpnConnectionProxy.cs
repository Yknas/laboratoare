using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class VpnConnectionProxy : IVpnConnection
    {
    
        private VpnConnection _vpnConnection;
        private Dictionary<string, string> _validUsers = new Dictionary<string, string>
        {
            { "user1", "password1" },
            { "user2", "password2" }

        };

        public VpnConnectionProxy(string serverAddres, int port)
        {
            _vpnConnection = new VpnConnection(serverAddres, port);// se creaza  obiectul (conexiunea vpn)
        }

        //metoda de autentificare care verifica username si parola
        private bool Authenticate(string username, string password)
        {
            return _validUsers.ContainsKey(username) && _validUsers[username] == password;
        }

        public void Connect()
        {
            Console.WriteLine("Please enter your username:");
            string username = Console.ReadLine(); 
            Console.WriteLine("Please enter your password:");
            string password = Console.ReadLine();

            // verifică daca utilizatorul este in dictionar
            if (Authenticate(username, password))  
            {
                _vpnConnection.Connect();//  se conectează la serverul VPN
                Console.WriteLine("User has been successfully connected to the VPN server.");
            }
            else
            {
                Console.WriteLine("Authentication failed.");  
            }
        }

        

        public void Disconnect()
        {
            _vpnConnection.Disconnect();  // Deconectează utilizatorul
            Console.WriteLine("User has been disconnected from the VPN server.");
        }

       
    }
}
