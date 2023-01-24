using System.ComponentModel.DataAnnotations;

namespace CW_ordermedicine.Data.Models
{
    public class AddGroup
    {
        
        public int GroupID { get; set; }
        [Required(ErrorMessage = "กรุณากรอกชื่อกลุ่ม")]
        public string? GroupName { get; set; }
        [Required(ErrorMessage = "กรุณาเลือกแผนก")]
        public string? Department { get; set; }
        public string? Status { get; set; }
    }
}
