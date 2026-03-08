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
        public Guid ProductId { get; set; } = Guid.NewGuid();
        [Required]
        public string ProductName { get; set; } = string.Empty;
        [Required]
        public decimal Price { get; set; }
        
        public DateTime? Expirationdate { get; set; }

        public Guid GuidId { get; set; }
        public Category Category { get; set; }
        public Stock Stock { get; set; }
        public Brand Brand { get; set; }

        


        

        public Product(){}


        public Product(Guid productId, string productName, decimal price)  
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
            
            
        }
    }
}
