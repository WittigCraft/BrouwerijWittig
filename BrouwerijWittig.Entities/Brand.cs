using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrouwerijWittig.Entities
{
    public class Brand : Product
    {
        public string BrandName { get; set; }



        public Brand()
        {
            
        }

        public Brand(string brandName)
        {
            BrandName = brandName;
            ProductId = Guid.NewGuid();
        }
    }
}
