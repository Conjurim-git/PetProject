using Microsoft.EntityFrameworkCore;

namespace PetProject.Models
{
    public class ApplicationContext : DbContext 
    {
        public DbSet<User> Users { get; set; } = null;
        public ApplicationContext(DbContextOptions<ApplicationContext> options): base (options) 
        {
        }
    }
}
