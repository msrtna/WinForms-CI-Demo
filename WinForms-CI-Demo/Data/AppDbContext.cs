using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WinForms_CI_Demo.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=WinFormsCIDemo;Trusted_Connection=True;");
        }
        public void Seed()
        {
            if (!Users.Any())
            {
                Users.Add(new User
                {
                    Username = "admin",
                    Password = "123"
                });

                SaveChanges();
            }
        }
    }
}
