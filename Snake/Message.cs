using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Message
    {
        public HorisontalLine topLine = new HorisontalLine(26, 52, 8, '=');
        public HorisontalLine bottomLine = new HorisontalLine(26, 52, 16, '=');
        public string text = @"И Г Р А   О К О Н Ч Е Н А";
        public string author = @"created by  Paul Winter";
    }
}
