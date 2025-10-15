using System.ComponentModel.DataAnnotations;

namespace MabeyaECommerce.Models
{
    public class LoginUserModel
    {
        [Display(Name = "E-posta")]

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
        public string? UserName{ get; set; }
        [Display(Name = "Parola")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
        public string? Password { get; set; }
        [Display(Name = "Oturum açık kalsın.")]
        public bool IsPersistent{ get; set; }
        public string? ReturnUrl { get; set; }
    }
}
