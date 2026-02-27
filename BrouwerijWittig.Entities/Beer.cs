using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrouwerijWittig.Entities
{
    public class Beer : Product
    {
        public string Origin { get; set; }
        public decimal AlcoholPercentage { get; set; }

        public Beer()
        {
            
        }

        public Beer(string origin, decimal alcoholPercentage)
        {
            
            Origin = origin;
            AlcoholPercentage = alcoholPercentage;
        }

        
    }
}
