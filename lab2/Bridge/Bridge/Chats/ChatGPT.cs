using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Chats
{
    class ChatGPT : ChatAI
    {
        public override void Chat()  
        {
            Console.WriteLine($"Interfata: {NavigationWeb.DisplayInterface()}\n");
            Console.WriteLine($"Pentru intrebarea {NavigationWeb.GetAnswer()} chatul GPT a oferit raspunsul {NavigationWeb.GiveResponse()}\n");
        }
    }
}
