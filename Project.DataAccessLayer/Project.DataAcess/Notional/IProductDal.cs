using Project.Core.DataAcces;
using Project.Core.DataAcces.EntityFramework;
using Project.Entities.Tangible;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.DataAcess.Notional
{
    public interface IProductDal : IEntityRepository<Product>
    {

    }
}
