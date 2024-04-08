using Dapper;
using PetShopManagement.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopManagement.DAO
{
    internal class ManagerDAO : IGetIDNumberFromDB
    {
        private static ManagerDAO instance;

        internal static ManagerDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ManagerDAO();
                }
                return instance;
            }
            private set => instance = value;
        }

        public ManagerDAO() { }

        public int GetIDNumber()
        {
            int iDNumber = 0;
            string theLastID = "";

            string tableName = "Manager";
            string query = "EXECUTE USP_GetTheLastIDNumber @table";

            theLastID = DataProvider.Instance.ExecuteScalar(query,new { table = tableName}).ToString();
            iDNumber = Convert.ToInt32(theLastID.Substring(2,3));

            return iDNumber;
        }
    }
}
