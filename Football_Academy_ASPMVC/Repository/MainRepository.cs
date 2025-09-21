using Football_Academy_ASPMVC.Data;
using Football_Academy_ASPMVC.Repository.Base;

namespace Football_Academy_ASPMVC.Repository
{
    public class MainRepository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        
        public MainRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(T entity) 
        {
            _context.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
           
        }
        public void Delete(T entity)
        {

            _context.Set<T>().Remove(entity);
        }

        public IEnumerable<T> FindAll()
        {
            return _context.Set<T>().ToList();
        }

        public T FindById(int id)
        {
            return _context.Set<T>().Find(id);
        }   

    }
}
