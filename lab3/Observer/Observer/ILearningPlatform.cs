using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
     public  interface ILearningPlatform
    {
        void AddStudent(IStudent student);
        void RemoveStudent(IStudent student);
        void NotifyStudent(string notification);
    }
}
