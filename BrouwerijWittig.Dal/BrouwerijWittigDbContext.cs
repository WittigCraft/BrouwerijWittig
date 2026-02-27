using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrouwerijWittig.Entities;

namespace BrouwerijWittig.Dal
{
    internal class BrouwerijWittigDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Stock> Stocks { get; set; }

        public BrouwerijWittigDbContext() : base(@"Data Source=CODINGMACHINE\SQLEXPRESS;Initial Catalog=BrouwerijWittigDb;Integrated Security=True")
        {
        }

         /*
          // Stap 1: Migraties inschakelen --> slechts één maal nodig
          // EntityFramework6\Enable-Migrations

          // Stap 2: Migratie toevoegen (klaarzetten om database aan te passen) --> iedere keer je een wijziging aanbrengt bij Entities
          // EntityFramework6\Add-Migration naam  

          //stap 3: Migratie uitvoeren (database effectief aanpassen) --> iedere keer nadat je eerrst stap 2 gedaan hebt
         // EntityFramework6\Update-Database
          
          */


    }
}
