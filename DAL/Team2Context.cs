using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MIS4200Team2.Models; // This is needed to access the models
using System.Data.Entity; // this is needed to access the DbContext object

namespace MIS4200Team2.DAL
{
    public class Team2Context : DbContext // inherits from DbContext
    {
        public Team2Context() : base("name=DefaultConnection")
       {

        // this method is a 'constructor' and is called when a new context is created
        // the base attribute says which connection string to use

        // add the set initializer statement here
         // Database.SetInitializer(new MigrateDatabaseToLatestVersion<Team2Context, MIS4200Team2.Migrations..Configuration>("DefaultConnection"));
        }
        public DbSet<userProfile> userProfiles { get; set; }
        public DbSet<recognitions> recognitions { get; set; }

       // public System.Data.Entity.DbSet<MIS4200Team2.Models.userProfile> userProfiles { get; set; }

       // public System.Data.Entity.DbSet<MIS4200Team2.Models.recognitions> recognitions { get; set; }
    }

    // Include each object here. The value inside <> is the name of the class,
    // the value outside should generally be the plural of the class name
    // and is the name used to reference the entity in code

    // public System.Data.Entity.DbSet<Hankins_MIS4200.Models.Customer> Customers { get; set; } <-- idk what this is



}