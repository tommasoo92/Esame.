using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Esame.Data
{
    public class Piatto
    {
        public int id { get; set; }
        public string tipo_portata { get; set; }
        public string allergeni { get; set; }
        public string stagione { get; set; }
        public string prezzo { get; set; }
    }
}
