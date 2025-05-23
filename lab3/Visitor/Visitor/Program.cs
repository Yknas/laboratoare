using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Visitor;

namespace Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Truck truck = new Truck();
            Motorcycle motorcycle = new Motorcycle();

            EngineMechanicVisitor mechanic = new EngineMechanicVisitor();

            car.Accept(mechanic);
            Console.WriteLine(mechanic.FinalMessage);

            truck.Accept(mechanic);
            Console.WriteLine(mechanic.FinalMessage);

            motorcycle.Accept(mechanic);
            Console.WriteLine(mechanic.FinalMessage);
        }
    }
}
