using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrouwerijWittig.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public List<Product> Products { get; set; }

        public Category()
        {
            
        }

        public Category(int categoryId, string categoryName, string productName)
        {
            CategoryId = categoryId;
            CategoryName = categoryName;
            ProductName = productName;
            
        }

    }
}
