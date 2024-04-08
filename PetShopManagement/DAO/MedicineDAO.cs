using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopManagement.DAO
{
    internal class MedicineDAO
    {
        private static MedicineDAO instance;

        internal static MedicineDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MedicineDAO();
                }
                return instance;
            }
            private set => instance = value;
        }

        private MedicineDAO() { }

        // Method 
        public int GetIDNumberFromDB()
        {
            int intIDNumber = 0;
            string theLastID = "";

            string tableName = "Medicine";
            string query = "EXECUTE USP_GetTheLastIDNumber @table";

            theLastID = DataProvider.Instance.ExecuteScalar(query, new { table = tableName }).ToString();
            intIDNumber = Convert.ToInt32(theLastID.Substring(2, 3));

            return intIDNumber;
        }
    }
}
