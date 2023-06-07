using System.Collections;
using System.Collections.Generic;

namespace proekt_zavurshvane__11d.model
{
    public class ProductType
    {
        public int Id { get; set; }
        public string Name { get; set; }

       public ICollection<Parcel> Parcels { get; set; }

    }
}