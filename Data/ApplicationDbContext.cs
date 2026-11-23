using Microsoft.EntityFrameworkCore;
using TareasMvc.Models;

namespace TareasMvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Tarea> Tareas { get; set; } = default!;
    }
}
