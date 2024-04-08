using PetShopManagement.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetShopManagement
{
    public class Foods : Product
    {
        //private static string keyWord = "FO";

        public Foods()
        {
            CreateID();
        }

        // Method
        public override void CreateID()
        {
            int idNumber = ProductDAO.Instance.GetIDNumberFromDB() + 1;
            this.ID = StringID(keyWord,idNumber);

            
        }
    }
}