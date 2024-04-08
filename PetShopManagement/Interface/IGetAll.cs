using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopManagement.Interface
{
    internal interface IGetAll<T>
    {
        List<T> GetAll();
    }
}
