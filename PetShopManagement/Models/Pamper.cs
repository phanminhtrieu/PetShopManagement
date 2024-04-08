using PetShopManagement.DAO;
using PetShopManagement.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetShopManagement
{
    public class Pamper : Service
    {
        //private static string keyWord = "PA";

        // Constructor
        public Pamper() { }
        public Pamper(string id, string name, decimal price)
        {
            ID = id;
            Name = name;
            Price = price;
        }
        public Pamper(Pamper record)
        {
            ID = record.ID;
            Name = record.Name;
            Price = record.Price;
        }

        // Method
        public override void CreateID()
        {
            int intLastID = ServiceDAO.Instance.GetIDNumberFromDB();
            int idNumber = intLastID + 1;
            this.ID = StringID(keyWord, idNumber);
        }

    }
}