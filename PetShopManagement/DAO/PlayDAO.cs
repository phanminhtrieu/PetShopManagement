using PetShopManagement.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopManagement.DAO
{
    internal class PlayDAO : IGetAll<Play>
    {
        private static PlayDAO instance;

        internal static PlayDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PlayDAO();
                }
                return instance;
            }
            private set => instance = value;
        }

        private PlayDAO() { }

        public List<Play> GetAll()
        {
            List<Play> plays = new List<Play>();

            string query = "SELECT ID, Name, Price from Service as service, Play as play"+ " " 
                         + "WHERE service.ID = play.ServiceID";
            List<Play> data = DataProvider.Instance.Query<Play>(query);

            foreach (var record in data)
            {
                Play play = new Play(record);
                plays.Add(play);
            }

            return plays;
        }
    }
}
