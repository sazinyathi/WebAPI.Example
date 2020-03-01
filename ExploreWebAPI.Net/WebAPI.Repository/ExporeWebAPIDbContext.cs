using ExpoloreWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Repository
{
    public class ExporeWebAPIDbContext : DbContext
    {
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}



