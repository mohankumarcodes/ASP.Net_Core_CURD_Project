using CURD_Project_WebAPI.Models;
using Microsoft.EntityFrameworkCore;


namespace CURD_Project_WebAPI.DB
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {
            
        }

        public DbSet<Student> students { get; set; }    

    }
}
