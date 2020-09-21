using JobBoardApp.Contracts;
using JobBoardApp.Data;
using JobBoardApp.Models;

namespace JobBoardApp.Repository
{
    public class JobBoardRepository : RepositoryBase<JobBoard>, IJobBoardRepository
    {
        public JobBoardRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}