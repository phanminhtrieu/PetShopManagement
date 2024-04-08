using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopManagement.Interface
{
    internal interface ICRUD<T>
    {
        // Create
        bool Insert();

        // Read
        List<T> Read();

        // Update
        bool Update();

        // Delete
        bool Delete();

    }
}
