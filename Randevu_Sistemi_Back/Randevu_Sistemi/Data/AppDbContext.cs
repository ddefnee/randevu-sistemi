using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Randevu_Sistemi.Models;


namespace Randevu_Sistemi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Randevu> Randevular { get; set; }
    }
}
