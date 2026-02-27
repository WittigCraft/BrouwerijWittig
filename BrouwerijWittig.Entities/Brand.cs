using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrouwerijWittig.Entities
{
    internal class Brand
    {
        public string BrandName { get; set; }



        public Brand()
        {
            
        }

        public Brand(string brandName)
        {
            BrandName = brandName;
        }
    }
}
