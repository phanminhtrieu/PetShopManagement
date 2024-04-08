using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetShopManagement
{
    public class Bill_Product : Bill
    {
        // Fields
        private static string keyWord = "BI";
        private string productID;

        // Properties
        public string ProductID { get => productID; set => productID = value; }

    }
}