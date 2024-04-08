using PetShopManagement.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetShopManagement
{
    public abstract class Offerings : PetShop
    {
        // Fields
        private string iD;
        private string name;
        private decimal price;

        // Properties
        public string ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public decimal Price { get => price; set => price = value; }


    }
}