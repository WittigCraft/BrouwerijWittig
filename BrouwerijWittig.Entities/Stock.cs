using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrouwerijWittig.Entities
{
    public class Stock : Product
    {
        public int AmountInStock { get; set; }
        public bool InStock { get; set; }
        public bool FactoryOrdered { get; set; }
        public DateTime BackInStock { get; set; }
        public List<Product> Products { get; set; }
        

        public Stock()
        {
            
        }


        public Stock(Guid productId, string productName, bool inStock, int amountInStock, Category category, bool factoryOrdered, DateTime backInStock)
        {
               
               ProductName = productName;
               InStock = inStock;
               AmountInStock = amountInStock;
               Category = category;
               FactoryOrdered = factoryOrdered;
               BackInStock = backInStock;
               if (AmountInStock > 0) InStock = true;
               InStock = InStock;
               Products = new List<Product>();
        }

        
    }

    
}
