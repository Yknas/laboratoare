using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class MathPlatformStudent : IStudent
    {
        private readonly string _name;

        public MathPlatformStudent(string name)
        {
            _name = name;
        }
        public void Update(string notification)
        {
           Console.WriteLine($"{_name} a primit notificarea: {notification}");
        }
    }
}
