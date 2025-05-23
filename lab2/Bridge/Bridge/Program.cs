
using Bridge.Chats;
using Bridge.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
     class Program
    {
        static void Main(string[] args)
        {
            ChatAI chat1 = new ChatGPT();
            ChatAI chat2 = new ChatGemeni();

            chat1.NavigationWeb = new ChromeNavigation("What can I help you?", "(oricare întrebare)", "(raspunsul oferit...)");

            chat2.NavigationWeb = new OperaNavigation("Hello, user! ","(oricare întrebare)","(raspunsul oferit...)");

            chat1.Chat();
            chat2.Chat();
        }
    }
}
