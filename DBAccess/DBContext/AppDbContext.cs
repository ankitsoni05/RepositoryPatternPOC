using DBAccess.ApplicationUser;
using DBAccess.DataAccessModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAccess.DBContext
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
           : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        //public DbSet<Division> divisions { get; set; }
        //public DbSet<Depo> depos { get; set; }
        //public DbSet<Driver> drivers { get; set; }
        //public DbSet<DriverPay> driverPays { get; set; }
    }
}
