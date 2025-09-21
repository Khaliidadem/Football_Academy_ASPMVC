using Football_Academy_ASPMVC.Models;

namespace Football_Academy_ASPMVC.Repository.Base
{
    public interface IUnitOfWork
    {
        IRepository<Player> players { get; }
        IRepository<Coach> coachs { get; }
        IRepository<Team> teams { get; }
        IRepository<Match> matches { get; }
        IRepository<MedicalStaff> medicalStaff { get; } 
        IRepository<Subscription> subscriptions { get; }

        void Save();
    }
}
