using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Collegues
{
    abstract class TeamMember
    {
        protected IManagerMediator _mediator;

        public readonly string Role;

        public TeamMember(IManagerMediator mediator, string role)
        {
            _mediator = mediator;
            Role = role;
        }

        public  abstract void ReciveMessage(string message);
        
        public abstract void Notify(string message);
    }

}
