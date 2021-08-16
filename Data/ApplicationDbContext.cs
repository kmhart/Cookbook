using System;
using System.Collections.Generic;
using System.Text;
using Cookbook.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Cookbook.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Recipe> Recipes { get; set; }

        public DbSet<Step> Steps { get; set; }

        public DbSet<Ingredient> Ingredients { get; set; }
    }
}
