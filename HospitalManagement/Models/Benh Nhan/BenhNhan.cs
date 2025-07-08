using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models
{
    public class BenhNhan
    {
        [Key]
        [Required]
        [StringLength(15, ErrorMessage = "CMT không được vượt quá 15 ký tự.")]
        public string CMT { get; set; }  // Khóa chính

        [Required(ErrorMessage = "Mã bệnh nhân không được để trống.")]
        [StringLength(10, ErrorMessage = "Mã bệnh nhân không được vượt quá 10 ký tự.")]
        public string MaBenhNhan { get; set; }  // Duy nhất

        [Required(ErrorMessage = "Tên bệnh nhân không được để trống.")]
        [StringLength(100, ErrorMessage = "Tên bệnh nhân không được vượt quá 100 ký tự.")]
        public string Ten { get; set; }

        [Required(ErrorMessage = "Ngày sinh không được để trống.")]
        [DataType(DataType.Date)]
        public DateTime NgaySinh { get; set; }

        [StringLength(255, ErrorMessage = "Địa chỉ không được vượt quá 255 ký tự.")]
        public string? DiaChi { get; set; }  // Không bắt buộc

        [StringLength(15, ErrorMessage = "Số điện thoại không được vượt quá 15 ký tự.")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Số điện thoại chỉ được chứa chữ số.")]
        public string? SoDienThoai { get; set; }
    }
}
