using PetShopManagement.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetShopManagement
{
    public class Manager : Employee
    {
        private static string keyWord = "MA";

        // Constructor
        public Manager()
        {
            CreateID();
        }

        // Methods
        public override void CreateID()
        {
            int iDNumber = ManagerDAO.Instance.GetIDNumber() + 1;
            this.ID = StringID(keyWord, iDNumber);
        }
    }
}