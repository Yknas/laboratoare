using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class EspressoCommand : ICoffeeCommand
       
    {
        private readonly CoffeeMachine _machine;

        public EspressoCommand(CoffeeMachine machine)
        {
            _machine = machine;
        }

        void ICoffeeCommand.Execute()
        {
            _machine.MakeEspresso();
        }
    }
}
