using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrouwerijWittig.Entities;

namespace BrouwerijWittig.Dal
{
    public static class BeerDal
    {

        // CREATE   

        // READ ALL
        public static List<Beer> Read()
        {
            using (var db = new BrouwerijWittigDbContext())
            {
                List<Beer> lstBeers = db.Beers.ToList();
                return lstBeers;
            }
        }

        // READ SINGLE
        public static Beer Read(Guid id)
        {
            using (var db = new BrouwerijWittigDbContext())
            {
                // We zoeken een bier met het opgegeven id
                Beer b = db.Beers.Find(id);
                return b;
            }
        }

        // UPDATE

        // DELETE
    }
}
