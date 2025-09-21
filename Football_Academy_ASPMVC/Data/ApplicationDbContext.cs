
using Football_Academy_ASPMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Football_Academy_ASPMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public virtual DbSet<Player> players { get; set; }
        public virtual DbSet<Coach> coaches { get; set; }
        public virtual DbSet<Team> teams { get; set; }
       public virtual DbSet<Match> matches { get; set; }    
        public virtual DbSet<MedicalStaff> MedicalStaff { get; set; }
        public virtual DbSet<Subscription> subscriptions { get; set; }  
        public virtual DbSet<PlayerMedicalStaff> PlayerMedicalStaff { get; set; }

    }
}






