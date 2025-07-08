
using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models
{
    public class Thuoc
    {
        [Key]
        [Required(ErrorMessage = "Mã thuốc không được để trống.")]
        public string MaThuoc { get; set; }

        [Required(ErrorMessage = "Tên thuốc không được để trống.")]
        [StringLength(100, ErrorMessage = "Tên thuốc không được vượt quá 100 ký tự.")]
        public string TenThuoc { get; set; }

        [Required(ErrorMessage = "Ngày sản xuất không được để trống.")]
        [DataType(DataType.Date)]
        public DateTime NgaySanXuat { get; set; }

        [Required(ErrorMessage = "Ngày hết hạn không được để trống.")]
        [DataType(DataType.Date)]
        [Compare(nameof(NgaySanXuat), ErrorMessage = "Ngày hết hạn phải lớn hơn ngày sản xuất.")]
        public DateTime NgayHetHan { get; set; }

        [Required(ErrorMessage = "Giá thuốc không được để trống.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Giá thuốc phải lớn hơn 0.")]
        public decimal Gia { get; set; }

        [Required(ErrorMessage = "Số lượng không được để trống.")]
        [Range(1, int.MaxValue, ErrorMessage = "Số lượng phải lớn hơn 0.")]
        public int SoLuong { get; set; }
    }
}

