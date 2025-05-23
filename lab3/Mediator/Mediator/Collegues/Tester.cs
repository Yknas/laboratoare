using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Collegues
{
    class Tester : TeamMember
    {
        public Tester(IManagerMediator mediator, string role) : base(mediator, role)
        {
        }

        public override void Notify(string message)
        {
            Console.WriteLine("Mesaj pentru tester: " + message);
        }

        public override void ReciveMessage(string message)
        {
            _mediator.SendMessage(message, this);
        }
    }
}
