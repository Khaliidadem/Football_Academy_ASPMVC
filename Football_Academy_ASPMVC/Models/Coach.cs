using System.ComponentModel.DataAnnotations;

namespace Football_Academy_ASPMVC.Models
{
    public class Coach
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }

        public int Age { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public string Teamleading { get; set; }


        public virtual ICollection<Player> Players { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }
}
