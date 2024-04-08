using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopManagement.Interface
{
    internal interface ICRUDDAO<T>
    {
        // Create
        bool Insert(T item);

        // Read
        List<T> Read(List<T> items);

        // Update
        bool Update(T item);

        // Delete
        bool Delete(T item);
    }
}
