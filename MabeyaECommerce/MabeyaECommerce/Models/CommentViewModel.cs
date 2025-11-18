using System.ComponentModel.DataAnnotations;

namespace MabeyaECommerce.Models;

public class CommentViewModel
{

    public Guid ProductId { get; set; }
    public string? ProductName { get; set; }
    [Required(ErrorMessage = "Yorum boş olamaz")]

    public string? Text { get; set; }
    [Range(1, 5, ErrorMessage = "Puan 1-5 arasında olmalıdır")]

    public int Rating { get; set; }
}
