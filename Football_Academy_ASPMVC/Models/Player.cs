using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Football_Academy_ASPMVC.Models
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        public string FullName  { get; set; }

        public int Age { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        //[ForeignKey]
        public int? TeamId { get; set; }

        public virtual Team Team { get; set; }

        public int? CoachId { get; set; }
        public virtual Coach Coach { get; set; }

        // العلاقة مع الطاقم الطبي
        public virtual ICollection<PlayerMedicalStaff> PlayerMedicalStaffs { get; set; }

    }
}
