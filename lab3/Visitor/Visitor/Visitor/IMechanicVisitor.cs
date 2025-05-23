using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    //Visitor Interface 
     interface IMechanicVisitor
    {
        void Visit(Car car);
        void Visit(Motorcycle moto);
        void Visit(Truck truck);

    }
}
