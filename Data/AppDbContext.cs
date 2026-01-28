using Microsoft.EntityFrameworkCore;

using pract12_trpo.Classes;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract12_trpo.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=sql.ects;Database=KaramovUsersDB;User Id=student_10;Password=student_10;TrustServerCertificate=True;");
        }
    }
}
