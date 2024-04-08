using Dapper;
using PetShopManagement.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopManagement.DAO
{
    internal class Bill_ServiceDAO : IGetTheLastIDFromDB, IGetIDNumberFromDB, ICheckOut<Bill_Service>
    {
        private static Bill_ServiceDAO instance;

        public static Bill_ServiceDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Bill_ServiceDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        private Bill_ServiceDAO() { }


        // Lấy ID bill chưa thanh toán (status = 1) dựa vào id Crate
        public string GetUncheckBillServiceIDByCrateID(string crateID)
        {
            string query = "select * from Bill_Service WHERE CrateID = @id and Status = 1";
            List<Bill_Service> billServiceData = DataProvider.Instance.Query<Bill_Service>(query, new { id = crateID});
            if (billServiceData.Count > 0)
            {
                // Tạo một đối tượng bill_service mới bằng data của phần tử đầu tiên trong list billServiceData
                Bill_Service billService = new Bill_Service(billServiceData[0]); 
                return billService.ID;
            }

            return null;
        }

        // Hàm này sẽ đẩy một cái bill_Service chỉ có ID và CrateID lên database
        public bool InsertBillServiceWithIDAndCrateID(Bill_Service bill_Service)
        {
            string query = "EXECUTE USP_InsertBillServiceIntoCrate @id, @crateID";
            int numberOfRowsAffected = DataProvider.Instance.Execute(query, new { id = bill_Service.ID, crateID = bill_Service.CrateID});
            if (numberOfRowsAffected > 0)
            {
                return true;
            }
            return false;
        }
        public bool InsertBillServiceIntoCrateByCrateID(string crateID)
        {
            // Câu query này hoạt động với điều kiện Bill_Service đó đã tồn tại trong một crate 
            string query = "EXECUTE USP_InsertBillServiceByCrateID @crateID";
            int numberOfRowsAffected = DataProvider.Instance.Execute(query, new { crateID = crateID});
            if (numberOfRowsAffected > 0)
            {
                return true;
            }
            return false;
        }

        public string GetTheLastIDFromDatabaseByTable()
        {
            string theLastID = "";
            string tableName = "Bill_Service";

            string queryCheckTalbe = "SELECT COUNT(*) FROM Bill_Service";
            bool tableIsNull = (int)DataProvider.Instance.ExecuteScalar(queryCheckTalbe) == 0;

            // Nếu bảng rỗng thì sẽ không có dòng cuối cùng --> Nên không thể lấy được cái last id --> BL000 là ID cuối cùng
            if (tableIsNull)
            {
                theLastID = "BL000";
                return theLastID;
            }
            else
            {
                string query = "EXECUTE USP_GetTheLastIDNumber @table";
                theLastID = DataProvider.Instance.ExecuteScalar(query, new { table = tableName }).ToString();
                return theLastID;
            }
        }

        public int GetIDNumber()
        {
            int iDNumber = 0;
            string theLastID = GetTheLastIDFromDatabaseByTable();
            iDNumber = Convert.ToInt32(theLastID.Substring(2, 3)); // hoàn thành tách tiền tố mã

            return iDNumber;
        }

        public bool CheckOut(string billServiceID) // Chuyển status thành 0 và cập nhật tổng tiền vào database với ngày check out
        {
            // Từ ID biến thành Bill
            Bill_Service bill_Service = Bill_ServiceDAO.instance.GetBillServiceByBillServiceID(billServiceID);
            bill_Service.DateCheckOut = DateTime.Now;

            string query = "EXECUTE USP_CheckOut @billServiceID , @totalMoney , @dateCheckOut";
            
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("billServiceID", bill_Service.ID);
            parameters.Add("totalMoney", bill_Service.TotalMoney);
            parameters.Add("dateCheckOut", bill_Service.DateCheckOut);


            int numberOfRowsAffected = DataProvider.Instance.Execute(query, parameters);
            if (numberOfRowsAffected > 0)
            {
                return true;
            }
            return false;
        }

        public bool CheckOut(Bill_Service bill_Service) // Chuyển status thành 0 và cập nhật tổng tiền vào database với ngày check out
        {
            bill_Service.DateCheckOut = DateTime.Now;

            string query = "EXECUTE USP_CheckOut @billServiceID , @totalMoney , @dateCheckOut";

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("billServiceID", bill_Service.ID);
            parameters.Add("totalMoney", bill_Service.TotalMoney);
            parameters.Add("dateCheckOut", bill_Service.DateCheckOut);


            int numberOfRowsAffected = DataProvider.Instance.Execute(query, parameters);
            if (numberOfRowsAffected > 0)
            {
                return true;
            }
            return false;
        }

        public Bill_Service GetBillServiceByBillServiceID(string billServiceID)
        {
            Bill_Service bill_Service;

            string query = "SELECT * FROM Bill_Service WHERE ID = @billServiceID";
            List<Bill_Service> data = DataProvider.Instance.Query<Bill_Service>(query, new { billServiceID = billServiceID});

            // Chắc chắn data chỉ có một phần tử
            Bill_Service record = data.First();
            bill_Service = new Bill_Service(record);

            return bill_Service;
        }
    }
}
