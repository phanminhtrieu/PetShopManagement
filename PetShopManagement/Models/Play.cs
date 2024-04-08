using PetShopManagement.DAO;
using PetShopManagement.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetShopManagement
{
    public class Play : Service
    {
        //private static string keyWord = "PL";


        // Constructor
        public Play() { }
        public Play(string id, string name, decimal price)
        {
            ID = id;
            Name = name;
            Price = price;
        }

        public Play(Play record)
        {
            ID = record.ID;
            Name = record.Name;
            Price = record.Price;
        }


        // Method
        public override void CreateID()
        {
            int iDNumber = ServiceDAO.Instance.GetIDNumberFromDB() + 1;
            this.ID = StringID(keyWord, iDNumber);
        }

    }
}