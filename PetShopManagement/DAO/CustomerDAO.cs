using Dapper;
using PetShopManagement.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace PetShopManagement.DAO
{
    public class CustomerDAO : IGetIDNumberFromDB, IGetTheLastIDFromDB, IGetAll<Customer>, ICRUDDAO<Customer>
    {
        private static CustomerDAO instance;

        internal static CustomerDAO Instance 
        {   
            get
            {
                if (instance == null)
                {
                    instance = new CustomerDAO();
                }
                return instance;
            }
            private set => instance = value; 
        }

        public CustomerDAO() { }

        public string GetTheLastIDFromDatabaseByTable()
        {
            string theLastID = "";
            string tableName = "Customer";
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

        public List<Customer> GetAll()
        {
            List<Customer> customers = new List<Customer>();

            string query = "SELECT * FROM Customer";
            List<Customer> data = DataProvider.Instance.Query<Customer>(query);

            foreach (var record in data)
            {
                Customer customer = new Customer(record);
                customers.Add(customer);
            }

            return customers;
        }

        // CRUDDAO<T>
        public bool Insert(Customer item)
        {
            string query = "EXECUTE USP_InsertCustomer  @id, @firstName, @lastName, @phone, @address, @email";
            int numberOfRowsAreAffected = DataProvider.Instance.Execute(query, item);

            bool isCompeleted = numberOfRowsAreAffected > 0;

            if (isCompeleted)
            {
                return true;
            }
            return false;
        }


        public bool Update(Customer item)
        {
            string query = "EXECUTE USP_UpdateCustomer @id, @firstName, @lastName, @phone, @address, @email";
            int numberOfRowsAreAffected = DataProvider.Instance.Execute(query, item);

            bool isCompeleted = numberOfRowsAreAffected > 0;

            if (isCompeleted)
            {
                return true;
            }
            return false;
        }

        public bool Delete(Customer item)
        {
            string query = "DELETE FROM Customer WHERE ID = @id";
            int numberOfRowsAffected = DataProvider.Instance.Execute(query, new { id = item.ID });
            if (numberOfRowsAffected > 0)
            {
                return true;
            }
            return false;
        }
        public List<Customer> Read(List<Customer> items)
        {
            throw new NotImplementedException();
        }

        public bool IsCustomerHavingPet(Customer customer)
        {
            string query = "SELECT COUNT(*) FROM Pet WHERE CustomerID = @customerID";
            int numberOfPets = (int)DataProvider.Instance.ExecuteScalar(query, new { customerID = customer.ID});

            if (numberOfPets > 0)
            {
                return true;
            }
            return false;
        }
    }
}
