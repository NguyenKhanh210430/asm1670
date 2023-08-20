using COMP1640.Data.SeedData;
using FPTBook.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FPTBook.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUserModel, RoleModel, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<AppUserModel> Users { get; set; }
        public DbSet<RoleModel> Roles { get; set; }
        public DbSet<BookModel> Books { get; set; }
        public DbSet<CartModel> Carts { get; set; }
        public DbSet<OrderModel> Orders { get; set; }
        public DbSet<OrderDetailModel> OrderDetails { get; set; }
        public DbSet<StoreModel> Stores { get; set; }

         

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            //xoa chu asp trong dbo name neu can
            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                var tableName = entityType.GetTableName();
                if (tableName.StartsWith("AspNet"))
                {
                    entityType.SetTableName(tableName.Substring(6));
                }
            }

            SeedDataToDb.Seed(builder);

        }
    }
}
