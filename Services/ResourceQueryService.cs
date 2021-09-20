using Contracts;
using Persistence;
using Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    internal sealed class ResourceQueryService : IResourceQueryService
    {
        private readonly RepositoryDbContext _dbContext;

        public ResourceQueryService(RepositoryDbContext dbContext) => _dbContext = dbContext;

        public IEnumerable<ResourceDto> GetAllResources()
        {
            return _dbContext.Resources.ToList();
        }

        public ResourceDto GetResource(int id)
        {
            throw new NotImplementedException();
        }
    }
}
