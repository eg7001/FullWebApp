using System.Net;
using FullWebApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FullWebApp.Context;

public class ApplicationDbContext : IdentityDbContext<AppUser>
{
    public ApplicationDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
    {

    }

    // public DbSet<QkaTeDush> emri {get;set;}
    public DbSet<UserProfile> UserProfiles {get; set; }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<SavingGoal> SavingGoals { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {

        
        base.OnModelCreating(builder);
        List<IdentityRole> roles = new List<IdentityRole>
        {
            new IdentityRole
            {
                Name = "Admin",
                NormalizedName = "ADMIN"
            },
            new IdentityRole
            {
                Name = "User",
                NormalizedName = "USER"
            },
        };
        builder.Entity<IdentityRole>().HasData(roles);
    }
    
}