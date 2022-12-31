using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBot
{
    public class Interaction
    {
        public int ExpectedState { get; set; }
        public int SetState { get; set; }
        public Action<string> BotAction { get; set; }
    }
}
