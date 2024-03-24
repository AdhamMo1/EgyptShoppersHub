using EgyptShoppersHubCore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace EgyptShopper_sHubEF.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole[] { new IdentityRole { Id = Guid.NewGuid().ToString(),Name= "Client", NormalizedName="client".ToUpper(),ConcurrencyStamp=Guid.NewGuid().ToString() }, 
                                     new IdentityRole { Id = Guid.NewGuid().ToString(),Name= "Admin", NormalizedName="admin".ToUpper(),ConcurrencyStamp=Guid.NewGuid().ToString() } }
                ) ;
        }

    }
}
