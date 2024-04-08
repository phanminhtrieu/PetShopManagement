using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopManagement.DAO
{
    internal class ProductDAO
    {
        private static ProductDAO instance;

        internal static ProductDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProductDAO();
                }
                return instance;
            }
            private set => instance = value;
        }

        private ProductDAO() { }

        public int GetIDNumberFromDB()
        {
            int idNumber = 0;
            string theLastID = "";

            string tableName = "Product";
            string query = "EXECUTE USP_GetTheLastIDNumber @table";
            theLastID = DataProvider.Instance.ExecuteScalar(query, new { table = tableName }).ToString();
            idNumber = Convert.ToInt32(theLastID.Substring(2, 3));
            return idNumber;
        }
    }
}
