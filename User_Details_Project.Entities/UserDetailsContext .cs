using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.EntityFrameworkCore;

namespace User_Details_Project.Entities
{
    public class UserDetailsContext:DbContext
    {
        public UserDetailsContext(DbContextOptions<UserDetailsContext> options)
           : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("Server=172.20.12.202;Database=UserDB;Uid=janardhan.r;Pwd=Jana@2023");
            }
        }
        public DbSet<Users> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
