using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Directory : GitRepositoryComponent
        
    {
        //relatia de agregare (un composite poate avea mai multe componente )
        private List<GitRepositoryComponent> _components = new List<GitRepositoryComponent>();
        public Directory(string name ) : base (name) 
        {
        }  

        public override void Commit()
        {
            Console.WriteLine($"Committing directory: {Name}");

            //se face commit pt  fiecarui file din directoriu
            foreach (var component in _components)
                component.Commit();
        }

        public override void Display(int level = 0)
        {
            string spaces = new string(' ', level);

            Console.WriteLine( spaces +"└" + Name);

            //afisarea fiecarui file(copil) din directoriu

            foreach (var component in _components)
                component.Display(level +1);


        }
        
        public void AddComponent(GitRepositoryComponent component)
        {
            _components.Add( component );
        }

        public void RemoveComponent(GitRepositoryComponent component)
        {
            _components.Remove(component);
        }
    }
}
