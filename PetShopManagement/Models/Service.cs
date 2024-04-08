using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace PetShopManagement
{
    public class Service : Offerings
    {
        protected static string keyWord = "SE";

        public List<string> GetListOfServiceType()
        {
            List<string> listType = new List<string>();
            var types = Assembly.GetAssembly(typeof(Service)).GetTypes().Where(type => type.IsSubclassOf(typeof(Service))).ToList();
            foreach (var type in types)
            {
                listType.Add(type.Name);
            } 
            return listType;
        }
    }
}