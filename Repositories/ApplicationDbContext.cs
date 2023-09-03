using ABCareApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ABCareApp.Repositories
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base (options)
        {
            
        }

        //Agregar los diferentes modelos que se necesiten

        public DbSet<User> users { get; set; }

    }
}

