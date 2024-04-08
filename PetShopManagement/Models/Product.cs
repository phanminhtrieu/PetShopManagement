using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetShopManagement
{
    public class Product : Offerings
    {
        protected static string keyWord = "PR";


        // Field
        private int leftOver;

        // Property
        public int LeftOver { get => leftOver; set => leftOver = value; }
    }
}