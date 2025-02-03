using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class DataBaseContext:DbContext
    {
        public DataBaseContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        

        public DbSet<User> Users { get; set; } = null!;

     

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=192.168.0.103;" +
                "user=UserTestUser;" +
                "password=000000;database=HomeWork;",
                new MySqlServerVersion(new Version(8, 0, 25)));
        }
    }
}
