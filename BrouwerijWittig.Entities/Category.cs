using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrouwerijWittig.Entities
{
    public class Category
    {
        [Key]
        public Guid CategoryId { get; set; } = Guid.NewGuid();
        public string CategoryName { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();

        public Category(){}

        public Category(string categoryName)
        {
            
            CategoryName = categoryName;
            Products = new List<Product>();
            
        }

    }
}
