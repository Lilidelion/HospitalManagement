 
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

    namespace HospitalManagement.Models
    {
        public class HoaDon
        {
            [Key]
            public int MaHoaDon { get; set; }

            [Required(ErrorMessage = "Đơn thuốc không được để trống.")]
            public int MaDonThuoc { get; set; }

            [ForeignKey("MaDonThuoc")]
            public DonThuoc DonThuoc { get; set; }

            [Required(ErrorMessage = "Ngày lập hóa đơn không được để trống.")]
            [DataType(DataType.Date)]
            public DateTime NgayLap { get; set; }

            [Required(ErrorMessage = "Tổng tiền không được để trống.")]
            [Range(0.01, double.MaxValue, ErrorMessage = "Tổng tiền phải lớn hơn 0.")]
            public decimal TongTien { get; set; }

            [Required(ErrorMessage = "Phương thức thanh toán không được để trống.")]
            [StringLength(50, ErrorMessage = "Phương thức thanh toán không được vượt quá 50 ký tự.")]
            public string PhuongThucThanhToan { get; set; }

            
           
        }
    }




