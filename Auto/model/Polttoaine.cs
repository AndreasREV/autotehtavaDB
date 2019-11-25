using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autokauppa.model;
using System.Data.SqlClient;

namespace Autokauppa.model
{
    public class Polttoaine
    {
        int ID;
        string Polttoaineen_nimi;

        public int ID1 { get => ID; set => ID = value; }
        public string Polttoaineen_nimi1 { get => Polttoaineen_nimi; set => Polttoaineen_nimi = value; }
    }
}
