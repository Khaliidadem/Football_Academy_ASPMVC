using System.ComponentModel.DataAnnotations;

namespace Football_Academy_ASPMVC.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }

        public string TeamU12 { get; set; }
        public string TeamU15 { get; set; }
         public string TeamU18 { get; set; }

        public int? CoachId { get; set; }
        public virtual Coach Coach { get; set; }

        public virtual ICollection<Player> Players { get; set; }

    }
}
