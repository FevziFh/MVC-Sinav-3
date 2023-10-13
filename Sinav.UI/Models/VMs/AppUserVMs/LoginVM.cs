using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Sinav.UI.Models.VMs.AppUserVMs
{
    public class LoginVM
    {
        [DisplayName("Kullanıcı E-Mail")]
        [EmailAddress]
        [Required]
        public string Email{ get; set; }
        [DisplayName("Kullanıcı Şifre")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
