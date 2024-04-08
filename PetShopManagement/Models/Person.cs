using PetShopManagement.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetShopManagement
{
    public abstract class Person : PetShop
    {
        // Fields
        private string iD;
        private string firstName;
        private string lastName;
        private string phone;
        private string address;
        private string email;

        // Properties
        public string ID { get => iD; set => iD = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }

        //
    }

}