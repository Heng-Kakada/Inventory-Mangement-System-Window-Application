using IMS_Services.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS_Services.Services.Implementation;

public class SupplierServices : ICRUDServices<Supplier, byte>
{
    public static byte Add(Supplier entity)
    {
        throw new NotImplementedException();
    }

    public static bool Delete(byte id)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<Supplier> GetAll()
    {
        throw new NotImplementedException();
    }

    public static Supplier GetById(byte id)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<Supplier> GetByName(string name)
    {
        throw new NotImplementedException();
    }

    public static bool Update(Supplier entity)
    {
        throw new NotImplementedException();
    }
}
