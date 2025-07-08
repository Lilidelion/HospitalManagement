using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagement.Models
{
    public class DonThuoc2
    {

        [Key]
        public int MaDonThuoc { get; set; }

        [Required(ErrorMessage = "Bệnh nhân không được để trống.")]
        public int MaBenhNhan { get; set; }

        [ForeignKey("MaBenhNhan")]
        public BenhNhan BenhNhan { get; set; }

        [Required(ErrorMessage = "Bác sĩ không được để trống.")]
        public int MaBacSi { get; set; }

        [ForeignKey("MaBacSi")]
        public BacSi BacSi { get; set; }

        [Required(ErrorMessage = "Ngày kê đơn không được để trống.")]
        [DataType(DataType.Date)]
        public DateTime NgayKeDon { get; set; }

        [Required(ErrorMessage = "Tổng tiền không được để trống.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Tổng tiền phải lớn hơn 0.")]
        public decimal TongTien { get; set; }

        public ICollection<ChiTietDonThuoc> ChiTietDonThuoc { get; set; }
    }
    public class ChiTietDonThuoc
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int MaDonThuoc { get; set; }

        [ForeignKey("MaDonThuoc")]
        public DonThuoc DonThuoc { get; set; }

        [Required]
        public string MaThuoc { get; set; }

        [ForeignKey("MaThuoc")]
        public Thuoc Thuoc { get; set; }

        [Required(ErrorMessage = "Số lượng không được để trống.")]
        [Range(1, int.MaxValue, ErrorMessage = "Số lượng phải lớn hơn 0.")]
        public int SoLuong { get; set; }

        [Required(ErrorMessage = "Liều dùng không được để trống.")]
        [StringLength(255, ErrorMessage = "Liều dùng không được vượt quá 255 ký tự.")]
        public string LieuDung { get; set; }

        [Required(ErrorMessage = "Giá không được để trống.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Giá phải lớn hơn 0.")]
        public decimal Gia { get; set; }

        [Required(ErrorMessage = "Thành tiền không được để trống.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Thành tiền phải lớn hơn 0.")]
        public decimal ThanhTien { get; set; }
    }
}