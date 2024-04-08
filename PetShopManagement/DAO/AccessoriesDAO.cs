using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopManagement.DAO
{
    internal class AccessoriesDAO
    {
        private static AccessoriesDAO instance;

        internal static AccessoriesDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccessoriesDAO();
                }
                return instance;
            }
            private set => instance = value;
        }

        private AccessoriesDAO() { }

        public int GetIDNumberFromDB()
        {
            int idNumber = 0;
            string theLastID = "";

            string tableName = "Accessories";
            string query = "EXECUTE USP_GetTheLastIDNumber @table";
            theLastID = DataProvider.Instance.ExecuteScalar(query, new { table = tableName }).ToString();
            idNumber = Convert.ToInt32(theLastID.Substring(2, 3));
            return idNumber;
        }
    }
}
