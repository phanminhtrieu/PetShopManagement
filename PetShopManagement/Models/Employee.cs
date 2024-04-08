using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetShopManagement
{
    public class Employee : Person
    {
        // Fields
        private DateTime birthday;

        // Properties
        public DateTime Birthday { get => birthday; set => birthday = value; }

        public override void CreateID()
        {
            throw new NotImplementedException();
        }
    }
}