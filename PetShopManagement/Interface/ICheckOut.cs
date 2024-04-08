using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopManagement.Interface
{
    internal interface ICheckOut<T>
    {
        bool CheckOut(string ID);
        bool CheckOut(T obj);
    }
}
