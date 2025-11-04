using System.ComponentModel.DataAnnotations;

namespace MabeyaECommerce.Areas.Admin.Models
{
    public class SliderImagesDto
    {
        public Guid? Id { get; set; }
        public IFormFile? ImageFile { get; set; }
        public DateTime? CreatedAt { get; set; }

        [Display(Name = "Katalog")]
        public Guid? catalogId { get; set; }
     
        
        [Display(Name = "Url")]
        public string? Url { get; set; }

        [Display(Name = "Aktif")]
        public bool IsEnabled { get; set; }
      

     


    }
}
