using Mediator.Collegues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
     interface IManagerMediator
    {
        void SendMessage(string message, TeamMember member);
    }
}
