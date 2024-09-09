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
            Database.SetInitializer<WarehouseContext>(new DropCreateDatabaseAlways<WarehouseContext>());
  
            

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Corporate> Corporates { get; set; }
        public DbSet<InputFactor> InputFactors { get; set; }
        public DbSet<OutputFactor> OutputFactors { get; set; }
        public DbSet<InputFactorItem> InputFactorItems { get; set; }
        public DbSet<OutputFactorItem> OutputFactorItems { get; set; }
        public DbSet<User> Users { get; set; }
        
        public DbSet<Product> Products { get; set; }
        public DbSet<Profile> Profiles { get; set; }

        public DbSet<Warranty> Warranties { get; set;}


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            CreateUserConfig(modelBuilder);
            
        }
        protected void CreateUserConfig(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(u => u.ID);
            modelBuilder.Entity<User>()
                        .Property(p => p.Name)
                        .HasMaxLength(30)
                        .HasColumnName("full_name")
                        .HasColumnOrder(3)
                        .HasColumnType("varchar");


        }


    }
}
