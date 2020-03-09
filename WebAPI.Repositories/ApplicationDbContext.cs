using System.Data.Entity;
using WebAPI.Models;

namespace WebAPI.Repositories
{
   public class ApplicationDbContext:DbContext
    {
      
        public DbSet<Employee> Employees { get; set; }
    }
}
