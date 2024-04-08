using PetShopManagement.DAO;
using PetShopManagement.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

namespace PetShopManagement
{
    public class Customer : Person, ICRUD<Customer>
    {
        private static string keyWord = "CU";

        // Constructor
        public Customer() { }
        public Customer(string id, string firstName, string lastName, string phone, string address, string email)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Address = address;
            Email = email;
        }

        public Customer(Customer record)
        {
            ID= record.ID;
            FirstName = record.FirstName;
            LastName = record.LastName;
            Phone = record.Phone;
            Address = record.Address;
            Email = record.Email;
        }

        // Methods
        public override void CreateID()
        {
            int iDNumber = CustomerDAO.Instance.GetIDNumber() + 1;
            this.ID = StringID(keyWord, iDNumber);
        }
        public List<Pet> GetPets()
        {
            return PetDAO.Instance.GetPetsByCustomer(this);
        }
        public bool Insert()
        {
            return CustomerDAO.Instance.Insert(this);
        }
        public bool Delete()
        {
            return CustomerDAO.Instance.Delete(this);
        }
        public bool Update()
        {
            return CustomerDAO.Instance.Update(this);
        }
        public List<Customer> Read()
        {
            throw new NotImplementedException();
        }

        public bool IsCustomerHavingPet()
        {
            return CustomerDAO.Instance.IsCustomerHavingPet(this);
        }

    }
}