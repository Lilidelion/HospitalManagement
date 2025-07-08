using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace HospitalManagement.Models
{
    public class HoSoBenhAn2
    {
        [Key]
        [Required]
        [StringLength(50, ErrorMessage = "Mã lần khám không được vượt quá 50 ký tự.")]
        public string MaLanKham { get; set; }

        [StringLength(15, ErrorMessage = "CMT Bác Sĩ không được vượt quá 15 ký tự.")]
        public string? CMTBacSi { get; set; }

        [StringLength(15, ErrorMessage = "CMT Bệnh Nhân không được vượt quá 15 ký tự.")]
        public string? CMTBenhNhan { get; set; }

        // Khóa ngoại
        [ForeignKey("CMTBacSi")]
        public BacSi? BacSi { get; set; }

        [ForeignKey("CMTBenhNhan")]
        public BenhNhan? BenhNhan { get; set; }

        [Required(ErrorMessage = "Ngày vào viện không được để trống.")]
        [DataType(DataType.Date)]
        public DateTime NgayVaoVien { get; set; }

        [Required(ErrorMessage = "Ngày ra viện không được để trống.")]
        [DataType(DataType.Date)]
        public DateTime NgayRaVien { get; set; }

        [Required(ErrorMessage = "Tên bệnh không được để trống.")]
        [StringLength(255, ErrorMessage = "Tên bệnh không được vượt quá 255 ký tự.")]
        public string TenBenh { get; set; }
    }
}
