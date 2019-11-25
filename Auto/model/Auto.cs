using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autokauppa.model
{
    public class Auto
    {
        int ID;
        decimal Hinta;
        DateTime Rekisteri_Paivamaara;
        decimal Moottorin_tilavuus;
        int Mittarilukema;
        int AutonmerkkiID;
        int AutonmalliID;
        int VaritID;
        int PolttoaineID;
        
        public int ID1 { get => ID; set => ID = value; }
        public decimal Hinta1 { get => Hinta; set => Hinta = value; }
        public DateTime Rekisteri_Paivamaara1 { get => Rekisteri_Paivamaara; set => Rekisteri_Paivamaara = value; }
        public decimal Moottorin_tilavuus1 { get => Moottorin_tilavuus; set => Moottorin_tilavuus = value; }
        public int Mittarilukema1 { get => Mittarilukema; set => Mittarilukema = value; }
        public int AutonmerkkiID1 { get => AutonmerkkiID; set => AutonmerkkiID = value; }
        public int AutonmalliID1 { get => AutonmalliID; set => AutonmalliID = value; }
        public int VaritID1 { get => VaritID; set => VaritID = value; }
        public int PolttoaineID1 { get => PolttoaineID; set => PolttoaineID = value; }
    }
}
