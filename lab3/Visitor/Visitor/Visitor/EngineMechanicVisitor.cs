using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Visitor
{
    class EngineMechanicVisitor : IMechanicVisitor
    {
        public string FinalMessage = "";
        public void Visit(Car car)
        {
            FinalMessage =($" Repar motorul masinii: {car.Model}, pret: {car.Price} EUR");
        }

        public void Visit(Motorcycle moto)
        {
            FinalMessage = ($" Repar motorul motocicletei: {moto.Model}, pret: {moto.Price} EUR");
        }

        public void Visit(Truck truck)
        {
            FinalMessage = ($" Repar motorul camionului: {truck.Model}, pret: {truck.Price} EUR");
        }
    }
}
