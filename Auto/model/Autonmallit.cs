using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autokauppa.model
{

        public class Autonmallit
        {
            int id;
            string mallinimi;
            string merkkiid;

            public int Id { get => id; set => id = value; }
            public string Mallinimi { get => mallinimi; set => mallinimi = value; }
            public string Merkkiid { get => merkkiid; set => merkkiid = value; }
        }
    
}
