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
        public Guid ProductId { get; set; } = Guid.NewGuid(); // generate automatic a new guid for each new product
        [Required]
        public string ProductName { get; set; } = string.Empty;
        [Required]
        public decimal Price { get; set; }
        
        public DateTime? ExpirationDate { get; set; }

        public Guid GuidId { get; set; }
        public Category Category { get; set; }
        public Stock Stock { get; set; }
        public Brand Brand { get; set; }

        


        

        public Product(){}


        public Product(string productName, decimal price)  
        {
            
            ProductName = productName;
            Price = price;
            
            
        }
    }
}
