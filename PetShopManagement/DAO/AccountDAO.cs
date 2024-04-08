using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopManagement.DAO
{
    internal class AccountDAO
    {
        private static AccountDAO instance;

        internal static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccountDAO();
                }
                return instance;
            }
            private set => instance = value;
        }

        private AccountDAO() { }

        public bool Login(string userName, string passWord)
        {
            string query = "execute usp_login @userName , @passWord";
            List<object> data = DataProvider.Instance.Query<object>(query, new { userName = userName, passWord = passWord });
            if ( data.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
