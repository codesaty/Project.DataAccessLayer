using System;
using System.Collections.Generic;
using System.Text;
using Project.Core.Entities;

namespace Project.Entities.Tangible
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public short UnitsOnOrder { get; set; }
    }
}
