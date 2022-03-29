using Microsoft.EntityFrameworkCore;

namespace MiniTodo.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=NOTEBOOK-5KP7FMEG\\SQLEXPRESS;Database=MiniApi;Trusted_Connection=True;");
    }
}
