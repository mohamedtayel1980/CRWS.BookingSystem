using Domain.Repositories;
using Persistence.Repositories.ResourcesRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly Lazy<IResourceRepoManager> _lazyResourceRepoManager;
        public RepositoryManager(RepositoryDbContext dbContext)
        {
            _lazyResourceRepoManager = new Lazy<IResourceRepoManager>(() => new ResourceRepoManager(dbContext));
        }
        public IResourceRepoManager ResourceRepoManager =>
          _lazyResourceRepoManager.Value;
    }
}
