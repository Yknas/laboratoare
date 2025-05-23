using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
     class Truck:IVehicle
    {
        public string Model = "Volvo FH16";
        public double Price = 15000;
        public void Accept(IMechanicVisitor visitor)
        {
            visitor.Visit(this);
        }

        public string DisplayInfo()
        {
            return $"Truck: {Model}, Price: {Price} EUR";
        }
    }
}
