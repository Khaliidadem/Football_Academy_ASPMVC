using System.ComponentModel.DataAnnotations;

namespace Football_Academy_ASPMVC.Models
{
    public class PlayerMedicalStaff
    {
        [Key] 
        public int PlayerId { get; set; }
        public virtual Player Player { get; set; }

        public int MedicalStaffId { get; set; }
        public virtual MedicalStaff MedicalStaff { get; set; }

        public string Notes { get; set; } // ملاحظات عن علاج اللاعب
    }
}
