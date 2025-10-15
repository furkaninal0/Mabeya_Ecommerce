 using System.ComponentModel.DataAnnotations;

namespace MabeyaECommerce.Models;

public class RegisterViewModel
{
    [DataType(DataType.EmailAddress)]
    [Display(Name ="E-posta Adresiniz")]
    [Required(ErrorMessage ="{0} alanı boş bırakılamaz.")]
    public string? UserName { get; set; }
    [Display(Name = "İsim Soyisim")]
    [Required(ErrorMessage = "{0} alanı boş bırakılamaz.")]

    public string? GivenName { get; set; }
    [DataType(DataType.Password)]
    [Display(Name = "Parola")]
    [Required(ErrorMessage = "{0} alanı boş bırakılamaz.")]

    public string? Password { get; set; }
    [DataType(DataType.Password)] 
    [Display(Name = "Parola Tekrarı")]
    [Required(ErrorMessage = "{0} alanı boş bırakılamaz.")]
    [Compare("Password", ErrorMessage = "{0} ve {1} alanları aynı olmalıdır.")]
    public string? PasswordCheck { get; set; }


}
