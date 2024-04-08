using PetShopManagement.DAO;
using PetShopManagement.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetShopManagement
{
    public class Crate : PetShop
    {
        private static string keyWord = "CR";

        // Fields
        private string iD;
        private int status;

        // Properties
        public string ID { get => iD; set => iD = value; }
        public int Status { get => status; set => status = value; }

        // Constructor
        public Crate() { }
        public Crate(Crate record)
        {
            ID = record.ID;
            Status = record.Status;
        }

        // Method
        public override void CreateID()
        {
            int idNumber = CrateDAO.Instance.GetIDNumberFromDB() + 1;
            this.ID = StringID(keyWord, idNumber);
        }

        public string StatusToString()
        {
            if (Status == 1)
            {
                return "Not full";
            }
            else
            {
                return "Full";
            }
        }

        public Pet GetPetByCrateID(string crateID)
        {
            return PetDAO.Instance.GetPetByCrateID(crateID);
        }

    }
}