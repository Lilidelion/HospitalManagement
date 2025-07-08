using System;
using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models
{
    public class BacSi
    {
        [Key]
        [StringLength(15)]
        public string CMT { get; set; }  // Chứng minh thư (Primary Key)

        [Required]
        [StringLength(10)]
        public string MaBacSi { get; set; }  // Mã bác sĩ (Unique)

        [Required]
        [StringLength(100)]
        public string Ten { get; set; }  // Tên bác sĩ

        [Required]
        [DataType(DataType.Date)]
        public DateTime NgaySinh { get; set; }  // Ngày sinh

        [StringLength(255)]
        public string DiaChi { get; set; }  // Địa chỉ

        [StringLength(50)]
        public string BacNghe { get; set; }  // Bậc nghề

        public int? ThamNien { get; set; }  // Thâm niên (số năm, có thể null)

        [StringLength(100)]
        public string TrinhDo { get; set; }  // Trình độ đào tạo

        [StringLength(100)]
        public string ChuyenMon { get; set; }  // Chuyên môn
    }
}
