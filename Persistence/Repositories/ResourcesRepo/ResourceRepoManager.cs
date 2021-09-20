using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.ResourcesRepo
{
    internal sealed class  ResourceRepoManager: IResourceRepoManager
    {
        private readonly Lazy<IResourceCommandRepositry> _lazyResourceCommandRepositry;
        private readonly Lazy<IResourceQueryRepositry> _lazyResourceQueryRepositry;
        public ResourceRepoManager(RepositoryDbContext dbContext)
        {
            _lazyResourceCommandRepositry  = 
                new Lazy<IResourceCommandRepositry>(() => new ResourceCommandRepo(dbContext));
            _lazyResourceQueryRepositry =
                new Lazy<IResourceQueryRepositry>(() => new ResourceQueryRepo(dbContext));
        }
        public IResourceCommandRepositry ResourceCommandRepositry 
            => _lazyResourceCommandRepositry.Value;
        public IResourceQueryRepositry ResourceQueryRepositry => 
            _lazyResourceQueryRepositry.Value;
    }
}
