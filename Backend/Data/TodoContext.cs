using Microsoft.EntityFrameworkCore;
using Backend.Models;

namespace Backend.Data;

public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options) : base(options) { }

    public DbSet<Produto> Produtos => Set<Produto>();
}
