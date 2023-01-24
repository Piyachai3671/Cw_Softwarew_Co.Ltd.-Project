using System.ComponentModel.DataAnnotations;

namespace CW_ordermedicine.Data.Models
{
    public class RegisterUser
    {
        public int RG_ID { get; set; }
        [Required(ErrorMessage = "กรุณากรอกชื่อ")]
        public string? RG_Name { get; set; }
        public string? RG_Email { get; set; }

        public string? RG_Password { get; set; }

    }
}
