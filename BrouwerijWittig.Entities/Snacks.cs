using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrouwerijWittig.Entities
{
    public class Snacks : Product
    {
        public string Type { get; set; }
        public Product Product { get; set; }

        public Snacks()
        {
            
        }

        public Snacks(string productName, string type)
        {
            ProductName = productName;
            Type = type;
        }

    }
}
