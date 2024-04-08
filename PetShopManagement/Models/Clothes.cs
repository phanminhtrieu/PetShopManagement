using PetShopManagement.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetShopManagement
{
    public class Clothes : Product
    {
        //private static string keyWord = "CL";

        public Clothes()
        {
            CreateID();
        }

        // Method
        public override void CreateID()
        {
            int idNumber = ProductDAO.Instance.GetIDNumberFromDB() + 1;
            this.ID = StringID(keyWord, idNumber);
        }
    }
}