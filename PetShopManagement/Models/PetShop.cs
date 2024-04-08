using PetShopManagement.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetShopManagement
{
    public class PetShop : ICreateID
    {
        public virtual void CreateID()
        {
        }

        // Method
        public string StringID(string keyWordID, int number)
        {
            if (number < 10)
            {
                return keyWordID + "00" + number;
            }
            else
            {
                if (number < 100)
                {
                    return keyWordID + "0" + number;
                }
                else
                {
                    return keyWordID + number;
                }
            }
        }
    }
}