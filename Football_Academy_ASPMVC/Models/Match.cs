using System.ComponentModel.DataAnnotations;

namespace Football_Academy_ASPMVC.Models
{
    public class Match
    {
        [Key]
        public int Id { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public DateTime MatchDate { get; set; }
        public string Result { get; set; }     
    }
}
