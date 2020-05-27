using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFMigrationsSqlLiteMiniMarket.Models
{
    public class ViewProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cattegory { get; set; }
        public float Price { get; set; }
    }
}
