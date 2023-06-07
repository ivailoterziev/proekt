using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proekt_zavurshvane__11d.model
{
    public class ParcelContext:DbContext
    {
        public ParcelContext() : base ("ParcelContext")
        {

        }
        public DbSet<Parcel> Parcels { get; set; }
        public DbSet<ProductType>ProductTypes{ get; set; }





    }
    
}
