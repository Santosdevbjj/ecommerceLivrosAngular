// Models/Produto.cs
namespace Backend.Models;

/// <summary>
/// Representa um livro no e-commerce.
/// </summary>
public class Produto
{
    public int Id { get; set; } // Identificador único
    public string Titulo { get; set; } = string.Empty; // Título do livro
    public string Autor { get; set; } = string.Empty; // Nome do autor
    public decimal Preco { get; set; } // Preço do livro
    public string Categoria { get; set; } = string.Empty; // Gênero ou categoria
    public string ImagemUrl { get; set; } = string.Empty; // URL da imagem da capa
}
