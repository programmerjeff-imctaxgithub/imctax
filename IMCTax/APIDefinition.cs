using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMCTax
{
    public class APIDefinition
    {
        public string Name { get; set; }
        public string APIKey { get; set; }
        public string APIURI { get; set; }

        public Dictionary<string, string> Actions { get; set; }
    }
}
