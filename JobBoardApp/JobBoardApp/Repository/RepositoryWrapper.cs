using JobBoardApp.Contracts;
using JobBoardApp.Data;

namespace JobBoardApp.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private ApplicationDbContext _applicationDbContext;
        private IJobBoardRepository _jobBoardRepository;


        public IJobBoardRepository JobBoard{
            get {
                if(_jobBoardRepository == null)
                {
                    _jobBoardRepository = new JobBoardRepository(_applicationDbContext);
                }
                return _jobBoardRepository;
            }
        }
        
        public RepositoryWrapper(ApplicationDbContext repositoryContext)
        {
            _applicationDbContext = repositoryContext;
        }

        public void Save()
        {
            _applicationDbContext.SaveChanges();
        }
    }
}