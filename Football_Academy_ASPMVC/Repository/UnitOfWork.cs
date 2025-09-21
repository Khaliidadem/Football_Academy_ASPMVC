using Football_Academy_ASPMVC.Data;
using Football_Academy_ASPMVC.Models;
using Football_Academy_ASPMVC.Repository.Base;

namespace Football_Academy_ASPMVC.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context) 
        {
            _context = context;
            players = new MainRepository<Player>(_context);
            coachs = new MainRepository<Coach>(_context);
            teams = new MainRepository<Team>(_context);
            matches = new MainRepository<Match>(_context);
            medicalStaff = new MainRepository<MedicalStaff>(_context);
            subscriptions = new MainRepository<Subscription>(_context);
        }

        public IRepository<Player> players { get; }
        public IRepository<Coach> coachs { get; }
        public IRepository<Team> teams { get; }
        public IRepository<Match> matches { get; }
        public IRepository<MedicalStaff> medicalStaff { get; }
        public IRepository<Subscription> subscriptions { get; } 
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
