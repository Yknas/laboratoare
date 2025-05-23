using Bridge.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Chats
{
    abstract class ChatAI
    {
        public INavigationWeb NavigationWeb { get; set; }
        public abstract void Chat(); 

    }
}
