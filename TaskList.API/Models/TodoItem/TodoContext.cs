using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace TaskList.API.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItemModel> TodoItems { get; set; } = null!;
    }
}
