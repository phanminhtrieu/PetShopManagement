using PetShopManagement.DAO;
using PetShopManagement.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetShopManagement
{
    public class Staff : Employee
    {
        private static string keyWord = "ST";

        // Constructor
        public Staff()
        {
            CreateID();
        }

        // Methods
        public override void CreateID()
        {
            int iDNumber = StaffDAO.Instance.GetIDNumber() + 1;
            this.ID = StringID(keyWord, iDNumber);
        }
    }
}