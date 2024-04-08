using Dapper;
using PetShopManagement.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopManagement.DAO
{
    internal class Bill_Service_DetailsDAO : IGetTheLastIDFromDB, IGetIDNumberFromDB
    {
        private static Bill_Service_DetailsDAO instance;

        public static Bill_Service_DetailsDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Bill_Service_DetailsDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        private Bill_Service_DetailsDAO() { }


        // Hàm này dùng để lấy ra một list bill_service_details từ database từ id của bill_service chứa nó
        public List<Bill_Service_Details> GetListBillServiceDetails(string id)
        {
            List<Bill_Service_Details> listBillDetails = new List<Bill_Service_Details>();

            string query = "select * from Bill_Service_Details WHERE BillID = @id";
            List<Bill_Service_Details> data = DataProvider.Instance.Query<Bill_Service_Details>(query, new { id = id});

            foreach (var record in data)
            {
                Bill_Service_Details billDetails = new Bill_Service_Details(record);
                listBillDetails.Add(billDetails);
            }

            return listBillDetails;
        }

        public bool InsertBillServiceDetails(string billServiceID, string serviceID)
        {
            string query = "EXECUTE USP_InsertBillServiceDetails @id, @billID, @serviceID";
            Bill_Service_Details bill_Service_Details = new Bill_Service_Details();
            bill_Service_Details.CreateID();
            int numberOfRowsAffected = DataProvider.Instance.Execute(query, new { id = bill_Service_Details.ID, billID = billServiceID, serviceID = serviceID});

            if (numberOfRowsAffected > 0)
            {
                return true;
            }
            return false;
        }

        public int GetIDNumber()
        {
            int iDNumber = 0;
            string theLastID = GetTheLastIDFromDatabaseByTable();
            iDNumber = Convert.ToInt32(theLastID.Substring(2, 3)); // hoàn thành tách tiền tố mã

            return iDNumber;
        }

        public string GetTheLastIDFromDatabaseByTable()
        {
            string theLastID = "";
            string tableName = "Bill_Service_Details";

            // Check table có null hay không
            string queryCheckTalbe = "SELECT COUNT(*) FROM Bill_Service_Details";
            bool tableIsNull = (int)DataProvider.Instance.ExecuteScalar(queryCheckTalbe) == 0;


            // Nếu bảng rỗng thì sẽ không có dòng cuối cùng --> Nên không thể lấy được cái last id --> BL000 là ID cuối cùng
            if (tableIsNull)
            {
                theLastID = "BS000";
                return theLastID;
            }
            else
            {
                string query = "EXECUTE USP_GetTheLastIDNumber @table";
                theLastID = DataProvider.Instance.ExecuteScalar(query, new { table = tableName }).ToString();
                return theLastID;
            }
        }

        public bool DeleteBillServiceDetailsByID(string billServiceDetailsID)
        {
            string query = "DELETE FROM Bill_Service_Details WHERE ID = @id";
            int numberOfRowsAffected = DataProvider.Instance.Execute(query, new { id = billServiceDetailsID});

            if (numberOfRowsAffected > 0)
            {
                return true;
            }
            return false;
        }
    }
}
