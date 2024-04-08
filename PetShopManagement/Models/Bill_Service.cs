using PetShopManagement.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PetShopManagement
{
    public class Bill_Service : Bill
    {
        private static string keyWord = "BL";
        // Fields
        private string crateID;
        private DateTime? dateCheckOut;

        // Properties
        public string CrateID { get => crateID; set => crateID = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }

        // Constructor
        public Bill_Service() { }
        public Bill_Service(string id, DateTime? date, int status)
        {
            ID = id;
            DateCheckIn = date;
            Status = status;
        }

        public Bill_Service(Bill_Service record)
        {
            ID = record.ID;
            DateCheckIn = record.DateCheckIn;
            Status = record.Status;
            CrateID = record.CrateID;
            DateCheckOut = record.DateCheckOut;
        }

        public override void CreateID()
        {
            int idNumber = Bill_ServiceDAO.Instance.GetIDNumber() + 1;
            this.ID = StringID(keyWord,idNumber);
        }
    }
}