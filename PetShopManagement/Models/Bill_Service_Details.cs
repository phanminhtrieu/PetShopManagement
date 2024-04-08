using PetShopManagement.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetShopManagement
{
    public class Bill_Service_Details : PetShop
    {
        public static string keyWord = "BS";
        // Fields
        private string iD;
        private string billID;
        private string serviceID;

        // Properties
        public string ID { get => iD; set => iD = value; }
        public string BillID { get => billID; set => billID = value; }
        public string ServiceID { get => serviceID; set => serviceID = value; }

        // Constructor
        public Bill_Service_Details() { }
        public Bill_Service_Details(string id, string billID, string serviceID) 
        { 
            ID = id;
            BillID = billID;
            ServiceID = serviceID;
        }

        public Bill_Service_Details(Bill_Service_Details record)
        {
            ID = record.ID;
            BillID = record.BillID;
            ServiceID = record.ServiceID;
        }

        public override void CreateID()
        {
            int idNumber = Bill_Service_DetailsDAO.Instance.GetIDNumber() + 1;
            this.ID = StringID(keyWord, idNumber);
        }
    }
}