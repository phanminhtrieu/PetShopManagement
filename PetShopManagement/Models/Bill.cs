using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetShopManagement
{
    public class Bill : PetShop
    {
        // Fields
        private string iD;
        private DateTime? dateCheckIn;
        private int status;
        private decimal totalMoney;


        // Properties
        public string ID { get => iD; set => iD = value; }
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public int Status { get => status; set => status = value; }
        public decimal TotalMoney { get => totalMoney; set => totalMoney = value; }
    }
}