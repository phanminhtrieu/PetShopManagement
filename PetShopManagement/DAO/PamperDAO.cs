using PetShopManagement.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopManagement.DAO
{
    internal class PamperDAO : IGetAll<Pamper>
    {
        private static PamperDAO instance;

        internal static PamperDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PamperDAO();
                }
                return instance;
            }
            private set => instance = value;
        }

        private PamperDAO() { }

        public List<Pamper> GetAll()
        {
            List<Pamper> pampers = new List<Pamper>();

            string query = "SELECT ID, Name, Price from Service as service, Pamper as pamper"+" "
                          +"WHERE service.ID = pamper.ServiceID";
            List<Pamper> data = DataProvider.Instance.Query<Pamper>(query);
            foreach (Pamper record in data)
            {
                Pamper pamper = new Pamper(record);
                pampers.Add(pamper);
            }

            return pampers;
        }
    }
}
