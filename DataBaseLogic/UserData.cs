using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataBaseLogic
{
    public class UserData : DbContext
    {
        public DbSet<User> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                

                optionsBuilder.UseSqlServer("Server=DESKTOP-R2NV2PI\\SQLEXPRESS; Database=LoginWPF; Trusted_Connection=True;TrustServerCertificate=True");

            }
        }
    }

    
}
