using System.ComponentModel.DataAnnotations;

namespace Football_Academy_ASPMVC.Models
{
    public class MedicalStaff
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required]
        public string Role { get; set; } // Doctor, Nurse, Physiotherapist

        public string Department { get; set; }

        public string PhoneNumber { get; set; }

        // العلاقة مع اللاعبين
        public virtual ICollection<PlayerMedicalStaff> PlayerMedicalStaffs { get; set; }
    }
}
