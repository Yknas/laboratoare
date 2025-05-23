using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class File : GitRepositoryComponent
    {
        //apelarea constructului de baza la clasa abstracta 
        public File(string name) : base(name)
        {
        }

        public override void Commit()
        {
            Console.WriteLine($"Committing file: {Name}");
        }

        public override void Display(int level = 0)

        {
            //space in dependenta de nivel
            string spaces =new string(' ', level);

            Console.WriteLine( spaces +"└" + Name);
        }
    }
}
