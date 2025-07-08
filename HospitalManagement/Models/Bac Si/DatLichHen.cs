using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagement.Models
{
    public class DatLichHen
    {
        
            [Key]
            [Required]
            [StringLength(10, ErrorMessage = "Mã lịch hẹn không được vượt quá 10 ký tự.")]
            public string MaLichHen { get; set; }  // Khóa chính

            [Required(ErrorMessage = "CMT Bệnh Nhân không được để trống.")]
            [StringLength(15, ErrorMessage = "CMT Bệnh Nhân không được vượt quá 15 ký tự.")]
            public string CMTBenhNhan { get; set; }

            [StringLength(15, ErrorMessage = "CMT Bác Sĩ không được vượt quá 15 ký tự.")]
            public string? CMTBacSi { get; set; }

            [Required(ErrorMessage = "Ngày hẹn không được để trống.")]
            [DataType(DataType.DateTime)]
            public DateTime NgayHen { get; set; }

            [Required(ErrorMessage = "Trạng thái không được để trống.")]
            [StringLength(50, ErrorMessage = "Trạng thái không được vượt quá 50 ký tự.")]
            public string TrangThai { get; set; }  // Trạng thái (Chờ duyệt, Đã xác nhận, Đã hủy)

            [StringLength(500, ErrorMessage = "Ghi chú không được vượt quá 500 ký tự.")]
            public string? GhiChu { get; set; }  // Ghi chú thêm nếu có

            // Khóa ngoại
            [ForeignKey("CMTBenhNhan")]
            public BenhNhan? BenhNhan { get; set; }

            [ForeignKey("CMTBacSi")]
            public BacSi? BacSi { get; set; }

          
        }
    }

