using PetShopManagement.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopManagement.DAO
{
    internal class GroomingDAO : IGetAll<Grooming>
    {
        private static GroomingDAO instance;

        internal static GroomingDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GroomingDAO();
                }
                return instance;
            }
            private set => instance = value;
        }

        private GroomingDAO() { }

        public List<Grooming> GetAll()
        {
            List<Grooming> groomings = new List<Grooming>();

            string query = "SELECT ID, Name, Price from Service as service, Grooming as grooming" + " "
                          +"WHERE service.ID = grooming.ServiceID";

            List<Grooming> data = DataProvider.Instance.Query<Grooming>(query);
            foreach (var record in data)
            {
                Grooming grooming = new Grooming(record);
                groomings.Add(grooming);
            }


            return groomings;
        }
    }
}
