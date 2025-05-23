using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    abstract class GitRepositoryComponent
    {
        //initializam numele pt fiecare componenet din git repo
        public string Name { get; }
        public GitRepositoryComponent(string name)
        {
            Name = name;    
        }
        public abstract void Display(int level = 0);
        public abstract void Commit();
    }
}
