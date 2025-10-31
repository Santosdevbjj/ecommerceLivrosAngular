// Data/TodoContext.cs
using Microsoft.EntityFrameworkCore;
using Backend.Models;

namespace Backend.Data;

/// <summary>
/// Contexto do banco de dados usando Entity Framework.
/// </summary>
public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options) : base(options) { }

    public DbSet<Produto> Produtos => Set<Produto>();
}
