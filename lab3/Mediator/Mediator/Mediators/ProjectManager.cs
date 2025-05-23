using Mediator.Collegues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Mediators
{
    class ProjectManager : IManagerMediator
    {
        public TeamMember Client { get; set; }
        public TeamMember Developer { get; set; }
        public TeamMember Tester { get; set; }

        public void SendMessage(string message, TeamMember member)
        {
            if (member.Role == "Client")
                Developer.Notify(message);

            else if (member.Role == "Developer")
                Tester.Notify(message);

            else if (member.Role == "Tester")
                Client.Notify(message);

        }
    }
}
