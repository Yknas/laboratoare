using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
     class Motorcycle:IVehicle
    {
        public string Model = "Yamaha R1";
        public double Price = 1500;

        public void Accept(IMechanicVisitor visitor)
        {
            visitor.Visit(this);
        }

        public string DisplayInfo()
        {
            return $"Motorcycle {Model}, Price: {Price} EUR";

        }
    }
}
