using Project.Core.DataAcces.EntityFramework;
using Project.DataAcess.Notional;
using Project.Entities.Tangible;
using System;
using System.Collections.Generic;
using System.Text;
using Project.DataAcess.Context;

namespace Project.DataAcess.Tangible.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, NortwindContext>, IUserDal
    {

    }
}
