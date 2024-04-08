using PetShopManagement.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopManagement.DAO
{
    internal class FoodsDAO : IGetIDNumberFromDB
    {
        private static FoodsDAO instance;

        internal static FoodsDAO Instance 
        { 
            get
            {
                if (instance == null)
                {
                    instance = new FoodsDAO();
                }
                return instance;
            }
            private set => instance = value; 
        }

        private FoodsDAO() { }

        // Method 
        public int GetIDNumber()
        {
            int intIDNumber = 0;
            string theLastID = "";

            string tableName = "Foods";
            string query = "EXECUTE USP_GetTheLastIDNumber @table";

            theLastID = DataProvider.Instance.ExecuteScalar(query, new { table = tableName}).ToString();
            intIDNumber = Convert.ToInt32(theLastID.Substring(2,3));

            return intIDNumber;
        }
    }
}
