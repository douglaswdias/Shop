using System.ComponentModel.DataAnnotations;

namespace Shop.Models;

public class Product
{
    [Key]
    [Required(ErrorMessage = "Id é obrigatório")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Descrição é obrigatório")]
    [MaxLength(150, ErrorMessage = "Descrição deve ter no máximo 150 caracteres")]
    [MinLength(5, ErrorMessage = "Descrição deve ter no mínimo 5 caracteres")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Preço é obrigatório")]
    [DataType(DataType.Currency)]
    [Range(0.01, 9999.99, ErrorMessage = "Preço deve estar entre 0,01 e 9999,99")]
    public decimal Price { get; set; }

    [Required(ErrorMessage = "Categoria é obrigatória")]
    public int CategoryId { get; set; }

    public Category Cate { get; set; } = null!;
}