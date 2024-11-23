using IMS_Services.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS_Services.Services.Implementation;

public class UserServices : ICRUDServices<User, short>
{
    public static short Add(User entity)
    {
        throw new NotImplementedException();
    }

    public static bool Delete(short id)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<User> GetAll()
    {
        throw new NotImplementedException();
    }

    public static User GetById(short id)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<User> GetByName(string name)
    {
        throw new NotImplementedException();
    }

    public static bool Update(User entity)
    {
        throw new NotImplementedException();
    }
}
