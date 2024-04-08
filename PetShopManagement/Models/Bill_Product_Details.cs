using PetShopManagement.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetShopManagement
{
    public class Bill_Product_Details : PetShop
    {
        public static string keyWord = "BS";
        // Fields
        private string iD;
        private string billID;
        private string productID;

        // Properties
        public string ID { get => iD; set => iD = value; }
        public string BillID { get => billID; set => billID = value; }
        public string ProductID { get => productID; set => productID = value; }

        // Constructor
        public Bill_Product_Details() { }
        public Bill_Product_Details(string id, string billID, string serviceID)
        {
            ID = id;
            BillID = billID;
            ProductID = serviceID;
        }

        public Bill_Product_Details(Bill_Service_Details record)
        {
            ID = record.ID;
            BillID = record.BillID;
            ProductID = record.ServiceID;
        }

        public override void CreateID()
        {
            int idNumber = Bill_Service_DetailsDAO.Instance.GetIDNumber() + 1;
            this.ID = StringID(keyWord, idNumber);
        }
    }
}