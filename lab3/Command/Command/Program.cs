using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CoffeeMachine machine = new CoffeeMachine();

            ICoffeeCommand espresso = new EspressoCommand(machine);
            ICoffeeCommand cappuccino = new CappuccinoCommand(machine);

            CoffeePanel panel = new CoffeePanel();

            panel.SetCommand(espresso);
            panel.PressButton();  

            panel.SetCommand(cappuccino);
            panel.PressButton();

            Console.ReadLine();
        }
    }
}
