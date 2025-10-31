using Backend.Models;

namespace Backend.Data;

public static class DbInitializer
{
    public static void Seed(TodoContext context)
    {
        if (context.Produtos.Any()) return;

        var livros = new List<Produto>
        {
            new Produto { Titulo = "O Senhor dos Anéis", Autor = "J.R.R. Tolkien", Preco = 89.90M, Categoria = "Fantasia", ImagemUrl = "https://example.com/sda.jpg" },
            new Produto { Titulo = "Clean Code", Autor = "Robert C. Martin", Preco = 119.90M, Categoria = "Programação", ImagemUrl = "https://example.com/cleancode.jpg" },
            new Produto { Titulo = "Dom Casmurro", Autor = "Machado de Assis", Preco = 39.90M, Categoria = "Literatura Brasileira", ImagemUrl = "https://example.com/domcasmurro.jpg" }
        };

        context.Produtos.AddRange(livros);
        context.SaveChanges();
    }
}
