namespace Domain.Repositories
{
    public interface IRepositoryManager
    {
        IResourceRepoManager ResourceRepoManager { get; }
    }
}
