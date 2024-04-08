using PetShopManagement.DAO;
using PetShopManagement.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetShopManagement
{
    public class Grooming : Service
    {
        //private static string keyWord = "GR";

        // Constructor
        public Grooming() { }
        public Grooming(string id, string name, decimal price)
        {
            ID = id;
            Name = name;
            Price = price;
        }
        public Grooming(Grooming record)
        {
            ID = record.ID;
            Name = record.Name;
            Price = record.Price;
        }


        // Method
        public override void CreateID()
        {
            int idNumber = ServiceDAO.Instance.GetIDNumberFromDB() + 1;
            this.ID = StringID(keyWord,idNumber);
        }

    }
}