using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagement.Models
{
    public class QuanTri
    {
        [Key]
        [Required]
        [StringLength(10, ErrorMessage = "Mã quản trị không được vượt quá 10 ký tự.")]
        public string MaQuanTri { get; set; }  // Khóa chính

        [Required(ErrorMessage = "Tên không được để trống.")]
        [StringLength(100, ErrorMessage = "Tên không được vượt quá 100 ký tự.")]
        public string Ten { get; set; }

        [Required(ErrorMessage = "Ngày sinh không được để trống.")]
        [DataType(DataType.Date)]
        public DateTime NgaySinh { get; set; }

        [StringLength(255, ErrorMessage = "Địa chỉ không được vượt quá 255 ký tự.")]
        public string? DiaChi { get; set; }  // Không bắt buộc

        [Required(ErrorMessage = "Số điện thoại không được để trống.")]
        [StringLength(15, ErrorMessage = "Số điện thoại không được vượt quá 15 ký tự.")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Số điện thoại chỉ được chứa chữ số.")]
        public string SoDienThoai { get; set; }  // UNIQUE

        [Required(ErrorMessage = "Email không được để trống.")]
        [StringLength(100, ErrorMessage = "Email không được vượt quá 100 ký tự.")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ.")]
        public string Email { get; set; }  // UNIQUE

        [StringLength(15, ErrorMessage = "CMT Bác Sĩ không được vượt quá 15 ký tự.")]
        public string? CMTBacSi { get; set; }

        [StringLength(15, ErrorMessage = "CMT Bệnh Nhân không được vượt quá 15 ký tự.")]
        public string? CMTBenhNhan { get; set; }

        // Khóa ngoại
        [ForeignKey("CMTBacSi")]
        public BacSi? BacSi { get; set; }

        [ForeignKey("CMTBenhNhan")]
        public BenhNhan? BenhNhan { get; set; }
    }
}
