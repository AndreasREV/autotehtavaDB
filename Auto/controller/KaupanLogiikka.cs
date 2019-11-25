using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Autokauppa.model;

namespace Autokauppa.controller
{

    
    //public class KaupanLogiikka
    //{
    //    DatabaseHallinta dbController = new DatabaseHallinta();
        

    //    public bool TestDatabaseConnection()
    //    {
    //        bool doesItWork = dbController.connectDatabase();
    //        dbController.disconnectDatabase();
    //        return doesItWork;
    //    }

    //    public bool saveAuto(model.Auto newAuto) 
    //    {
    //        bool didItGoIntoDatabase = dbController.saveAutoIntoDatabase(newAuto);
    //        return didItGoIntoDatabase;
    //    }



    //    public List<Autonmerkki> getAutoMakers()
    //    {
    //        List<Autonmerkki> autolista = dbController.getAllAutoMakers();
    //        return autolista;
    //        //return dbController.getAutoModelsByMakerId(makerId);
    //    }
    //    public List<Autonmallit> GetAutonmallits(int merkkiID)
    //    {
    //        List<Autonmallit> mallilista = dbController.GetAutonmallits(merkkiID);
    //        return mallilista;
    //    }
    //    public List<Varit> GetVarits()
    //    {
    //        List<Varit> varits = dbController.CarColors();
    //        return varits;
    //    }
    //    public List<Polttoaine> GetPolttoaines()
    //    {
    //        return dbController.CarFuel();
    //    }
    //    public bool SaveAuto(Auto pirssi)
    //    {
    //        bool kekeke = dbController.SafeCar(pirssi);
    //        return kekeke;
    //        //kekwSQUAD
    //    }
    //    public Auto NextCars(int ID)
    //    {
    //        if (ID == 0)
    //        {
    //            return  dbController.FirstCar(ID);
                
    //        }
    //        else
    //        {
    //            Auto haettuAuto = dbController.NextCar(ID);
    //            if (haettuAuto.ID1 == 0)
    //            {
    //                return dbController.FirstCar(ID);

    //            }
    //            return haettuAuto;
    //        }
    //    }
    //    public Auto PreviousCars(int ID)
    //    {
    //        if(ID == 0)
    //        {
    //           return dbController.LastCar();
              
    //        }
    //        else
    //        {
    //            Auto haettuAuto = dbController.PreviousCar(ID);
    //            if(haettuAuto.ID1 == 0)
    //            {
    //               return dbController.LastCar();  
                    
    //            }
    //            return haettuAuto;
    //        }    
    //    }
    }
//}
