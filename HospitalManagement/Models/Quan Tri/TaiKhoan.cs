using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models.Share
{
    public class TaiKhoan
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        [Required]
        public string Role { get; set; }
    }
}
