using PetShopManagement.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopManagement.DAO
{
    internal class Bill_ProductDAO : IGetIDNumberFromDB, IGetTheLastIDFromDB, ICheckOut<Bill_Product>
    {
        private static Bill_ProductDAO instance;

        public static Bill_ProductDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Bill_ProductDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        private Bill_ProductDAO() { }

        public string GetTheLastIDFromDatabaseByTable()
        {
            string theLastID = "";



            return theLastID;
        }

        public int GetIDNumber()
        {
            int idNumber = 0;

            

            return idNumber;
        }

        public bool CheckOut(string ID) 
        {
            throw new NotImplementedException();
        }

        public bool CheckOut(Bill_Product obj) // Chuyển status thành 0 và cập nhật tổng tiền vào database với ngày check out
        {
            throw new NotImplementedException();
        }
    }
}
