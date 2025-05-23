using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    //Receiver - stie cum sa prepare bautura
    public class CoffeeMachine
    {
        public void MakeEspresso()
        {
            Console.WriteLine("Espresso pregătit");
        }
        public void MakeCappuccino()
        {
            Console.WriteLine("Cappuccino pregătit");
        }
    }
}
