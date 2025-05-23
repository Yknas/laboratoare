using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
     class Car :IVehicle
    {
        public string Model = "BMW Seria 3";
        public double Price = 6000;


        public void Accept(IMechanicVisitor visitor)
        {
            visitor.Visit(this);
        }

        public string DisplayInfo()
        {
            return $"Car: {Model}, Price: {Price} EUR";
        }
    }
}
