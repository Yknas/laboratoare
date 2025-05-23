using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    interface IVpnConnection
    {
        //metodele pt conectare si deconectare la un vpnServer
        void Connect();
        void Disconnect();
    }

}
