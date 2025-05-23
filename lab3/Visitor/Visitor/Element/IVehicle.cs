using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{

    //Element
    interface IVehicle
    {
        void Accept(IMechanicVisitor visitor);
        string DisplayInfo();
    }
}
