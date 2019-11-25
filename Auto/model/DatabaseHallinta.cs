
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



//namespace Autokauppa.model
//{
    //public class DatabaseHallinta
    //{

    //    SqlConnection dbYhteys = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Autokauppa;Integrated Security=True;Connect Timeout=30" +
    //    ";Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    //    public DatabaseHallinta()
    //    {

    //    }

    //    public bool connectDatabase()
    //    {
    //        try
    //        {
    //            dbYhteys.Open();

    //            return true;
    //        }
    //        catch (Exception e)
    //        {
    //            Console.WriteLine("Virheilmoitukset:" + e);
    //            dbYhteys.Close();
    //            return false;
    //        }
    //    }
    //    public void disconnectDatabase()
    //    {
    //        dbYhteys.Close();
    //    }
    //    public bool saveAutoIntoDatabase(Auto newAuto)
    //    {
    //        bool palaute = false;
    //        return palaute;
    //    }
    //    /// <summary>
    //    /// Returns all auto makers
    //    /// </summary>
    //    /// <returns>List of makers</returns>
    //    public List<Autonmerkki> getAllAutoMakers()
    //    {
    //        dbYhteys.Open();
    //        List<Autonmerkki> autoMakers = new List<Autonmerkki>();
    //        SqlCommand jes1 = new SqlCommand("SELECT * FROM AutonMerkki", dbYhteys);
    //        SqlDataReader dasd = jes1.ExecuteReader();
    //        while (dasd.Read())
    //        {
    //            Autonmerkki jepulis = new Autonmerkki();
    //            jepulis.Id = (int)dasd["ID"];
    //            jepulis.Merkkinimi = (string)dasd["Merkki"];
    //            autoMakers.Add(jepulis);
    //        }
    //        dbYhteys.Close();
    //        return autoMakers;

    //    }
    //    /// <summary>
    //    /// Returns all chosen maker models
    //    /// </summary>
    //    /// <param name="merkkiID"></param>
    //    /// <returns></returns>
    //    public List<Autonmallit> GetAutonmallits(int merkkiID)
    //    {
    //        dbYhteys.Open();
    //        List<Autonmallit> autoModels = new List<Autonmallit>();
    //        SqlCommand jes2 = new SqlCommand("SELECT * FROM AutonMallit WHERE AutonMerkkiID=" + merkkiID, dbYhteys);
    //        SqlDataReader fasd = jes2.ExecuteReader();
    //        while (fasd.Read())
    //        {
    //            Autonmallit jeejee = new Autonmallit();
    //            jeejee.Id = (int)fasd["ID"];
    //            jeejee.Mallinimi = fasd["Auton_mallin_nimi"].ToString();
    //            autoModels.Add(jeejee);
    //        }
    //        dbYhteys.Close();
    //        return autoModels;
    //    }
    //    public List<Varit> CarColors()
    //    {
    //        dbYhteys.Open();
    //        List<Varit> autoColors = new List<Varit>();
    //        SqlCommand jes3 = new SqlCommand("SELECT * FROM Varit", dbYhteys);
    //        SqlDataReader asdf = jes3.ExecuteReader();
    //        while (asdf.Read())
    //        {
    //            Varit colorsor = new Varit();
    //            colorsor.ID1 = (int)asdf["ID"];
    //            colorsor.Varin_nimi1 = (string)asdf["Varin_nimi"];
    //            autoColors.Add(colorsor);
    //        }
    //        dbYhteys.Close();
    //        return autoColors;
    //    }
    //    public List<Polttoaine> CarFuel()
    //    {
    //        dbYhteys.Open();
    //        List<Polttoaine> autoFuel = new List<Polttoaine>();
    //        SqlCommand jes4 = new SqlCommand("SELECT * FROM Polttoaine", dbYhteys);
    //        SqlDataReader qwerty = jes4.ExecuteReader();
    //        while (qwerty.Read())
    //        {
    //            Polttoaine fuellii = new Polttoaine();
    //            fuellii.ID1 = (int)qwerty["ID"];
    //            fuellii.Polttoaineen_nimi1 = (string)qwerty["Polttoaineen_nimi"];
    //            autoFuel.Add(fuellii);
    //        }
    //        dbYhteys.Close();
    //        return autoFuel;
    //    }
    //    public bool SafeCar(Auto pirssi)
    //    {
    //        dbYhteys.Open();
    //        SqlCommand komento1 = new SqlCommand("INSERT INTO Auto *"+
    //        "VALUES(@hinta,@rekpvm,@mottlv,@mitlkv,@automerkki,@automalli,@autovari,@polttoaine)",dbYhteys);
    //        //SqlParameter autoadd = new SqlParameter("@Safecarpara",dbYhteys);
    //        //komento1.Parameters.Add(autoadd);
    //        SqlParameter hinta = new SqlParameter("@hinta", pirssi.Hinta1);
    //        komento1.Parameters.Add(hinta);
    //        SqlParameter rekisteri_paivamaara = new SqlParameter("@rekpvm", pirssi.Rekisteri_Paivamaara1);
    //        komento1.Parameters.Add(rekisteri_paivamaara);
    //        SqlParameter moottoritilavuus = new SqlParameter("@mottlv", pirssi.Moottorin_tilavuus1);
    //        komento1.Parameters.Add(moottoritilavuus);
    //        SqlParameter mittarilukema = new SqlParameter("@mitlkv", pirssi.Mittarilukema1);
    //        komento1.Parameters.Add(mittarilukema);
    //        SqlParameter merkki = new SqlParameter("@automerkki", pirssi.AutonmerkkiID1);
    //        komento1.Parameters.Add(merkki);
    //        SqlParameter malli = new SqlParameter("@automalli", pirssi.AutonmalliID1);
    //        komento1.Parameters.Add(malli);
    //        SqlParameter vari = new SqlParameter("@autovari", pirssi.VaritID1);
    //        komento1.Parameters.Add(vari);
    //        SqlParameter polttoaine = new SqlParameter("@polttoaine", pirssi.PolttoaineID1);
    //        komento1.Parameters.Add(polttoaine);
    //        int jep = komento1.ExecuteNonQuery();
    //        dbYhteys.Close();
    //        return true;
    //    }
    //    public Auto NextCar(int ID)
    //    {
    //        Auto seuraavaauto = new Auto();
    //        dbYhteys.Open();
    //        SqlCommand seuraava = new SqlCommand("SELECT TOP 1 * FROM AUTO WHERE ID>"+ID+" ORDER BY ID ASC", dbYhteys);
    //        SqlDataReader srvauto = seuraava.ExecuteReader();
    //        while(srvauto.Read())
    //        {              
    //            seuraavaauto.ID1 = (int)srvauto["ID"];
    //            seuraavaauto.Hinta1 = (decimal)srvauto["Hinta"];
    //            seuraavaauto.Rekisteri_Paivamaara1 = (DateTime)srvauto["Rekisteri_paivamaara"];
    //            seuraavaauto.Moottorin_tilavuus1 = (decimal)srvauto["Moottorin_tilavuus"];
    //            seuraavaauto.Mittarilukema1 = (int)srvauto["Mittarilukema"];
    //            seuraavaauto.AutonmerkkiID1 = (int)srvauto["AutonMerkkiID"];
    //            seuraavaauto.AutonmalliID1 = (int)srvauto["AutonMalliID"];
    //            seuraavaauto.VaritID1 = (int)srvauto["VaritID"];
    //            seuraavaauto.PolttoaineID1 = (int)srvauto["PolttoaineID"];
    //        }
    //        dbYhteys.Close();
    //        return seuraavaauto;
    //    }
    //    public Auto PreviousCar(int ID)
    //    {
    //        Auto edellinenauto = new Auto();
    //        dbYhteys.Open();
    //        SqlCommand edellinen = new SqlCommand("SELECT TOP 1 * FROM AUTO WHERE ID<"+ID+" ORDER BY ID DESC", dbYhteys);
    //        SqlDataReader prvauto = edellinen.ExecuteReader();
    //        while(prvauto.Read())
    //        {
    //            edellinenauto.ID1 = (int)prvauto["ID"];
    //            edellinenauto.Hinta1 = (decimal)prvauto["Hinta"];
    //            edellinenauto.Rekisteri_Paivamaara1 = (DateTime)prvauto["Rekisteri_paivamaara"];
    //            edellinenauto.Moottorin_tilavuus1 = (decimal)prvauto["Moottorin_tilavuus"];
    //            edellinenauto.Mittarilukema1 = (int)prvauto["Mittarilukema"];
    //            edellinenauto.AutonmerkkiID1 = (int)prvauto["AutonMerkkiID"];
    //            edellinenauto.AutonmalliID1 = (int)prvauto["AutonMalliID"];
    //            edellinenauto.VaritID1 = (int)prvauto["VaritID"];
    //            edellinenauto.PolttoaineID1 = (int)prvauto["PolttoaineID"];
    //        }
    //        dbYhteys.Close();
    //        return edellinenauto;
    //    }
    //    public Auto LastCar()
    //    {
    //        Auto viimeinenAuto = new Auto();
    //        dbYhteys.Open();
    //        SqlCommand viimeinen = new SqlCommand("SELECT TOP 1 * FROM AUTO ORDER BY ID DESC", dbYhteys);
    //        SqlDataReader lstcar = viimeinen.ExecuteReader();
    //        while(lstcar.Read())
    //        {
    //            viimeinenAuto.ID1 = (int)lstcar["ID"];
    //            viimeinenAuto.Hinta1 = (decimal)lstcar["Hinta"];
    //            viimeinenAuto.Rekisteri_Paivamaara1 = (DateTime)lstcar["Rekisteri_paivamaara"];
    //            viimeinenAuto.Moottorin_tilavuus1 = (decimal)lstcar["Moottorin_tilavuus"];
    //            viimeinenAuto.Mittarilukema1 = (int)lstcar["Mittarilukema"];
    //            viimeinenAuto.AutonmerkkiID1 = (int)lstcar["AutonMerkkiID"];
    //            viimeinenAuto.AutonmalliID1 = (int)lstcar["AutonMalliID"];
    //            viimeinenAuto.VaritID1 = (int)lstcar["VaritID"];
    //            viimeinenAuto.PolttoaineID1 = (int)lstcar["PolttoaineID"];
    //        }
    //        dbYhteys.Close();
    //        return viimeinenAuto;
    //    }
    //    public Auto FirstCar(int ID)
    //    {
    //        Auto ekaPirssi = new Auto();
    //        dbYhteys.Open();
    //        SqlCommand edellinen1 = new SqlCommand("SELECT TOP 1 * FROM AUTO  ORDER BY ID ASC", dbYhteys);
    //        SqlDataReader prvauto1 = edellinen1.ExecuteReader();
    //        while (prvauto1.Read())
    //        {
    //            ekaPirssi.ID1 = (int)prvauto1["ID"];
    //            ekaPirssi.Hinta1 = (decimal)prvauto1["Hinta"];
    //            ekaPirssi.Rekisteri_Paivamaara1 = (DateTime)prvauto1["Rekisteri_paivamaara"];
    //            ekaPirssi.Moottorin_tilavuus1 = (decimal)prvauto1["Moottorin_tilavuus"];
    //            ekaPirssi.Mittarilukema1 = (int)prvauto1["Mittarilukema"];
//    //            ekaPirssi.AutonmerkkiID1 = (int)prvauto1["AutonMerkkiID"];
//    //            ekaPirssi.AutonmalliID1 = (int)prvauto1["AutonMalliID"];
//    //            ekaPirssi.VaritID1 = (int)prvauto1["VaritID"];
//    //            ekaPirssi.PolttoaineID1 = (int)prvauto1["PolttoaineID"];
//    //        }
//    //        dbYhteys.Close();
//    //        return ekaPirssi;
//        }
//    }
//}
