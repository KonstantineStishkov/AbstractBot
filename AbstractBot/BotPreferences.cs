using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBot
{
    public abstract class BotPreferences
    {
        public string ApiKey { get; set; }
        public List<Interaction> Interactions { get; set; }
    }
}
