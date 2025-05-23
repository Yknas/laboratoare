using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class CappuccinoCommand : ICoffeeCommand
    {
        private readonly CoffeeMachine _machine;
        public CappuccinoCommand(CoffeeMachine machine)
        {
            _machine = machine;
        }

        public void Execute()
        {
           _machine.MakeCappuccino();
        }
    }
}
