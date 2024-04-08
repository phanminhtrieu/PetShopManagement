using PetShopManagement.DAO;
using PetShopManagement.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace PetShopManagement
{
    public class Pet : PetShop, ICRUD<Pet>
    {
        private static string keyWord = "PE";

        // Fields
        private string iD;
        private string type;
        private string crateID;
        private string customerID;
        private string description;
        private DateTime dateIn;
        private DateTime dateOut;
        private string size;
        private int status;

        // Properties
        public string ID { get => iD; set => iD = value; }
        public string Type { get => type; set => type = value; }
        public string CrateID { get => crateID; set => crateID = value; }
        public string CustomerID { get => customerID; set => customerID = value; }
        public string Description { get => description; set => description = value; }
        public DateTime DateIn { get => dateIn; set => dateIn = value; }
        public DateTime DateOut { get => dateOut; set => dateOut = value; }
        public string Size { get => size; set => size = value; }
        public int Status { get => status; set => status = value; }

        // Constructor
        public Pet() { }

        public Pet(Pet record)
        {
            // Constructor này tạo ra một đối tượng để nhận dữ liệu từ database ( 1 record = 1 object)
            ID = record.ID;
            Type = record.Type;
            CrateID = record.CrateID;
            CustomerID = record.CustomerID;
            Description = record.Description;
            DateIn = record.DateIn;
            DateOut = record.DateOut;
            Size = record.Size;
            Status = record.Status;
        }
        // Method
        public override void CreateID()
        {
            int idNumber = PetDAO.Instance.GetIDNumber() + 1;
            this.ID = StringID(keyWord, idNumber);
        }

        public string StatusToString()
        {
            string statusString = "";
            if (this.Status == 1)
            {
                statusString = "Pet is using service";
            }
            else
            {
                statusString = "Pet is not using service";
            }
            return statusString;
        }

        public bool Insert()
        {
            return PetDAO.Instance.Insert(this);
        }

        public List<Pet> Read()
        {
            throw new NotImplementedException();
        }

        public bool Update()
        {
            return PetDAO.Instance.Update(this);
        }

        public bool Delete()
        {
            return PetDAO.Instance.Delete(this);
        }
        
    }
}