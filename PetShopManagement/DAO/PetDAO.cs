using Dapper;
using PetShopManagement.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace PetShopManagement.DAO
{
    internal class PetDAO : IGetIDNumberFromDB, IGetTheLastIDFromDB, ICRUDDAO<Pet>, IGetAll<Pet>
    {
        private static PetDAO instance;

        internal static PetDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PetDAO();
                }
                return instance;
            }
            private set => instance = value;
        }

        private PetDAO() { }

        // Method 
        public string GetTheLastIDFromDatabaseByTable()
        {
            string theLastID = "";
            string tableName = "Pet";
            string query = "EXECUTE USP_GetTheLastIDNumber @table";
            theLastID = DataProvider.Instance.ExecuteScalar(query, new { table = tableName }).ToString();
            return theLastID;
        }
        public int GetIDNumber()
        {
            int iDNumber = 0;
            string theLastID = GetTheLastIDFromDatabaseByTable();
            iDNumber = Convert.ToInt32(theLastID.Substring(2, 3)); // hoàn thành tách tiền tố mã

            return iDNumber;
        }

        
        public Pet GetPetByCrateID(string crateID)
        {
            // Đảm bảo rằng các con pet đang ở chuồng nào đó vẫn chưa được thanh toán
            string query = "SELECT * FROM Pet WHERE CrateID = @crateID AND Status = 1";
            List<Pet> data = DataProvider.Instance.Query<Pet>(query, new { crateID = crateID});

            // Đảm bảo rằng ít nhất có một record đạt yêu cầu WHERE thì mới gán giá trị.
            // Nếu không có record nào thỏa thì không trả về con pet nào <=> null
            if (data.Count > 0)
            {
                Pet pet = data[0];
                return pet;
            }
            else
            {
                return null;
            }

        }


        public bool UpdatePetToPaid(string petID)
        {
            // Paid: Status == 0 và ngày giờ ngay lúc này
            string query = "UPDATE Pet SET Status = 0, DateOut = GETDATE() WHERE ID = @petID";
            int numberOfRowsAffected = DataProvider.Instance.Execute(query, new { petID = petID});
            if (numberOfRowsAffected > 0)
            {
                return true;
            }
            return false;
        }

        public List<Pet> GetPetsByCustomer(Customer customer)
        {
            List<Pet> result = new List<Pet>();
            string query = "SELECT * FROM Pet WHERE CustomerID = @customerID";
            List<Pet> data = DataProvider.Instance.Query<Pet>(query, new { customerID = customer.ID});
            foreach (var record in data)
            {
                Pet pet = new Pet(record);
                result.Add(pet);    
            }

            return result;
        }

        public bool Insert(Pet item)
        {
            string query = "INSERT INTO PET(ID,Type,CrateID,CustomerID,Description,DateIn,Size)"+ " "
                         + "VALUES(@id, @type, @crateID, @customerID, @description, @dateIn, @size)";
            DynamicParameters parameter = new DynamicParameters();
            parameter.Add("id",item.ID);
            parameter.Add("type",item.Type);
            parameter.Add("crateID",item.CrateID);
            parameter.Add("customerID", item.CustomerID);
            parameter.Add("description", item.Description);
            parameter.Add("dateIn", item.DateIn);
            parameter.Add("size", item.Size);

            int numberOfRowsAffected = DataProvider.Instance.Execute(query, parameter);
            if (numberOfRowsAffected > 0)
            {
                return true;
            }
            return false;
        }

        public List<Pet> Read(List<Pet> items)
        {
            throw new NotImplementedException();
        }

        public bool Update(Pet item)
        {
            string query = "EXECUTE USP_UpdatePet @id, @type, @customerID, @description, @dateIn, @dateOut";

            DynamicParameters parameter = new DynamicParameters();
            parameter.Add("id", item.ID);
            parameter.Add("type", item.Type);
            parameter.Add("customerID", item.CustomerID);
            parameter.Add("description", item.Description);
            parameter.Add("dateIn", item.DateIn);
            parameter.Add("dateOut", item.DateOut);

            int numberOfRowsAffected = DataProvider.Instance.Execute(query, parameter);

            if (numberOfRowsAffected > 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(Pet item)
        {
            string query = "DELETE FROM Pet WHERE ID = @id";
            int numberOfRowsAffected = DataProvider.Instance.Execute(query, new { id = item.ID });

            if (numberOfRowsAffected > 0)
            {
                return true;
            }
            return false;
        }

        public List<Pet> GetAll()
        {
            List<Pet> result = new List<Pet>();
            string query = "SELECT * FROM Pet";
            List<Pet> data = DataProvider.Instance.Query<Pet>(query);
            foreach (var record in data)
            {
                Pet pet = new Pet(record);
                result.Add(pet);
            }

            return result;
        }
    }
}
