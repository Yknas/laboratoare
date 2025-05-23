using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Navigation
{
    class OperaNavigation : INavigationWeb
    {

        public string _title;
        public string _answer;
        public string _response;

        public OperaNavigation(string title, string answer, string response)
        {
            _title = title;
            _answer = answer;
            _response = response;
        }
        public string DisplayInterface()
        {
            return _title;
        }

        public string GetAnswer()
        {
            return _answer;
        }

        public string GiveResponse()
        {
            return _response;
        }
    }
}
