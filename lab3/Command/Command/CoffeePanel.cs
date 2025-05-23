using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    //Invoker 
    public class CoffeePanel
    {
        private ICoffeeCommand _command;
        public void SetCommand(ICoffeeCommand command)
        {
            _command = command;
        }

        public void PressButton()
        {
            _command.Execute();
        }
    }
}
