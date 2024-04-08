using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopManagement.Models
{
    /// <summary>
    /// Đây là một lớp trung gian để hiển thị các cột cần hiển thị lên GUI
    /// 
    /// </summary>
    internal class MenuService
    {
        // Fields
        private string iD;
        private string name;
        private decimal price;

        // Properties
        public string Name { get => name; set => name = value; }
        public decimal Price { get => price; set => price = value; }
        public string ID { get => iD; set => iD = value; }

        // Constructor
        public MenuService() { }

        public MenuService(string id, string serviceName, decimal price)
        {
            ID = id;
            Name = serviceName;
            Price = price;
        }

        public MenuService( MenuService record) 
        {
            ID = record.ID;
            Name = record.Name;
            Price = record.Price;
        }
    }
}
