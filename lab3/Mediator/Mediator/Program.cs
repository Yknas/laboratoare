using Mediator.Collegues;
using Mediator.Mediators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
     class Program
    {
        static void Main(string[] args)
        {
            
            ProjectManager manager = new ProjectManager();


            
            Developer developer = new Developer(manager,"Developer");
            Client client = new Client (manager, "Client");
            Tester tester = new Tester (manager, "Tester");

            //asociem fiecare rol in mediator
            manager.Developer = developer;
            manager.Client = client;
            manager.Tester = tester;

            client.ReciveMessage("Avem o comandă, trebuie realizat programul ");
            developer.ReciveMessage("Programul este gata, trebuie testat");
            tester.ReciveMessage("Programul a fost testat si este gata de vânzare");

            Console.Read();

        }
    }
}
