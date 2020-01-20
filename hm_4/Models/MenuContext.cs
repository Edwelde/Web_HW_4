using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace hm_4.Models
{
    public class MenuContext : DbContext
    {
        public DbSet<Moderator> ModeratorList { get; set; }
        public DbSet<Admin> AdminList { get; set; }

        public MenuContext(DbContextOptions<MenuContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=MenuContext;Username=postgres;Password=1qasw23ed");
        }
    }
}
