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
    internal class StaffDAO : IGetIDNumberFromDB
    {
        private static StaffDAO instance;

        internal static StaffDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StaffDAO();
                }
                return instance;
            }
            private set => instance = value;
        }

        public StaffDAO() { }

        public int GetIDNumber()
        {
            int iDNumber = 0;
            using (SqlConnection connection = new SqlConnection(ConnectToDatabase.connectionString))
            {
                connection.Open();

                string tableName = "Staff";
                string query = "EXECUTE USP_GetIDNumber @table";
                //DynamicParameters parameters = new DynamicParameters();
                //parameters.Add("table", tableName);
                //iDNumber = Convert.ToInt32(connection.ExecuteScalar(query, parameters));

                iDNumber = Convert.ToInt32(connection.ExecuteScalar(query, new { table = tableName}));

                connection.Close();
            }
            return iDNumber;
        }
    }
}
