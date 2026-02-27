using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrouwerijWittig.Entities
{
    public class Product
    {
        [Key]
        public Guid ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public decimal Price { get; set; }
        public Category Category { get; set; }
        public DateTime Expirationdate { get; set; }
        public List<Beer> Beers { get; set; }
        public Stock Stock { get; set; }

        


        // Lege constructor

        public Product()
        {
            
        }


        public Product(string productName, decimal price)  
        {
            
            ProductName = productName;
            Price = price;
            
            
        }
    }
}
