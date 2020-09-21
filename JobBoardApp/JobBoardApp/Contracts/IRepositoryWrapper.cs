namespace JobBoardApp.Contracts
{
    public interface IRepositoryWrapper
    {
        IJobBoardRepository JobBoard { get; }
        void Save();
    }
}