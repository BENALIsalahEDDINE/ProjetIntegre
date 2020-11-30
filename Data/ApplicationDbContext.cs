using System;
using System.Collections.Generic;
using System.Text;
using Shop4Yourself.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Shop4Yourself.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CategoriesModel> categoriesModels { get; set; }

        public DbSet<ProductsModel> ProductsModel { get; set; }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }

        public DbSet<ShoppingCart> ShoppingCart { get; set; }

        public DbSet<OrderHeader> OrderHeader { get; set; }

        public DbSet<OrderDetail> OrderDetail { get; set; }
    }
}
