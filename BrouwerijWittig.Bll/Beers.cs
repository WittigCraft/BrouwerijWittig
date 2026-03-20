using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrouwerijWittig.Dal;
using BrouwerijWittig.Entities;

namespace BrouwerijWittig.Bll
{
    public static class Beers
    {
        // CREATE   
        public static bool Create(string productName, decimal price, string origin, decimal alcoholPercentage, decimal content)
        {
            if (!string.IsNullOrEmpty(productName) && price > 0 && !string.IsNullOrEmpty(origin) && alcoholPercentage > 0 && content > 0)
            {
                
                Beer b = new Beer(productName, price, origin, alcoholPercentage,content);
                return BeerDal.Create(b);
            }

            return false;
        }

        // READ ALL
        public static List<Beer> Read()
        {
            // get the beers from the database via dal
            List<Beer> lstBeers = BeerDal.Read();
            return lstBeers;
        }

        // READ SINGLE
        public static Beer Read(Guid id)
        {
            // get the beer with the given id from the database via dal
            Beer b = BeerDal.Read(id);
            if (b == null)
            {
                b = new Beer();
            }


            return b;
        }

        // UPDATE

        // DELETE
    }
}
