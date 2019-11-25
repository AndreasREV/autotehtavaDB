using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Autonmallit.model;
using Autokauppa.model;
using System.Data.SqlClient;

namespace Autokauppa.model
{
  
        public class Autonmerkki
        {
            int id;
            string merkkinimi;
            public int Id { get => id; set => id = value; }
            public string Merkkinimi { get => merkkinimi; set => merkkinimi = value; }                                 
        }

   
}
