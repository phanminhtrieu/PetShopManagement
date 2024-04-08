using Dapper;
using PetShopManagement.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopManagement.DAO
{
    public class CrateDAO : IGetAll<Crate>
    {
        private static CrateDAO instance;

        public static CrateDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CrateDAO();
                }
                return instance;
            }
            private set => instance = value;
        }

        // width & height
        public static int BtnCrateWidth = 90;
        public static int BtnCrateHeight = 90;

        private CrateDAO() { }

        // Method 
        public int GetIDNumberFromDB()
        {
            int intIDNumber = 0;
            string theLastID = "";

            string tableName = "Crate";
            string query = "EXECUTE USP_GetTheLastIDNumber @table";

            theLastID = DataProvider.Instance.ExecuteScalar(query, new { table = tableName }).ToString();
            intIDNumber = Convert.ToInt32(theLastID.Substring(2, 3));

            return intIDNumber;
        }

        public List<Crate> GetAll()
        {
            List<Crate> crates = new List<Crate>();

            string query = "SELECT * FROM Crate";
            List<Crate> data = DataProvider.Instance.Query<Crate>(query);

            foreach (var record in data)
            {
                Crate crate = new Crate(record);
                crates.Add(crate);
            }

            return crates;
        }

        public bool UpdateCrateStatusToFull(string crateID)
        {
            // Fulll == 0
            string query = "UPDATE Crate SET Status = 0 WHERE ID = @crateID";
            int numberOfRowsAffected = DataProvider.Instance.Execute(query, new { crateID = crateID});

            if (numberOfRowsAffected > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeletePetAndBillServiceByCrateID(string crateID)
        {
            string query = "EXEC USP_DeletePetAndBillServiceByCrateID @crateID";
            int numberOfRowsAffected = DataProvider.Instance.Execute(query, new { crateID = crateID});


            if (numberOfRowsAffected > 0)
            {
                return true;
            }
            return false;
        }

    }
}
