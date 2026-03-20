using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrouwerijWittig.Entities
{
    public class Beer : Product
    {
        public string Origin { get; set; } = string.Empty;
        public decimal AlcoholPercentage { get; set; }
        public decimal Content { get; set; }

        public Beer(){}

        public Beer(string productName, decimal price, string origin, decimal alcoholPercentage, decimal content) : base(productName, price)
        {
            
            Origin = origin;
            AlcoholPercentage = alcoholPercentage;
            Content = content;
        }

        
    }
}
