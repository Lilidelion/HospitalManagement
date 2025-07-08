using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace HospitalManagement.Models
{
    public class HoSoBenhAn1
    {
        [Key]
        public int RecordId { get; set; }

        [Required]
        [ForeignKey("Patient")]
        public int PatientId { get; set; }

        [Required]
        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

        public string Diagnosis { get; set; }

        public string Treatment { get; set; }

        public virtual BenhNhan Patient { get; set; }
        public virtual BacSi Doctor { get; set; }
    }
}
