using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Navigation
{
    interface INavigationWeb
    {
        string DisplayInterface();
        string GetAnswer();
        string GiveResponse();
    }
}
