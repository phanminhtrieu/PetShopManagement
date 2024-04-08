using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopManagement.DAO
{
    internal class ClothesDAO
    {
        private static ClothesDAO instance;

        internal static ClothesDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ClothesDAO();
                }
                return instance;
            }
            private set => instance = value;
        }

        private ClothesDAO() { }

        // Method 
        public int GetIDNumberFromDB()
        {
            int intIDNumber = 0;
            string theLastID = "";

            string tableName = "Clothes";
            string query = "EXECUTE USP_GetTheLastIDNumber @table";

            theLastID = DataProvider.Instance.ExecuteScalar(query, new { table = tableName }).ToString();
            intIDNumber = Convert.ToInt32(theLastID.Substring(2, 3));

            return intIDNumber;
        }
    }
}
