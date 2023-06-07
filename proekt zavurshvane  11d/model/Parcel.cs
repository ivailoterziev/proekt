using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proekt_zavurshvane__11d.model
{
    public class Parcel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
          
        public double Weight { get; set; }
        public double Price { get; set; }

        public int ProductTypesId { get; set; }
        public ProductType ProductTypes { get; set; }   

    }
}
