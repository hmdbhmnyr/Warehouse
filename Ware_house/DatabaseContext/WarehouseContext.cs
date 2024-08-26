using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Ware_house.classes;
using Ware_house.Models;

namespace Ware_house.DatabaseContext
{
    public class WarehouseContext:DbContext
    {
        public WarehouseContext():base("name=WarehouseDB") 
        {
            Database.SetInitializer<WarehouseContext>(new CreateDatabaseIfNotExists<WarehouseContext>());


        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Corporate> Corporates { get; set; }
        public DbSet<InputFactor> InputFactors { get; set; }
        public DbSet<OutputFactor> OutputFactors { get; set; }
        public DbSet<InputFactorItem> InputFactorItems { get; set; }
        public DbSet<OutputFactorItem> OutputFactorItems { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Product> Products { get; set; }
        
    }
}
