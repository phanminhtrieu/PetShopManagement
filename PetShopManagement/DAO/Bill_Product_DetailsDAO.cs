using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopManagement.DAO
{
    internal class Bill_Product_DetailsDAO 
    {
        private static Bill_Product_DetailsDAO instance;

        public static Bill_Product_DetailsDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Bill_Product_DetailsDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        private Bill_Product_DetailsDAO() { }


    }
}
