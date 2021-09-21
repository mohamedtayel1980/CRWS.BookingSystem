using Contracts;
using Domain.Repositories;
using Mapster;
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
        private readonly IRepositoryManager _repositoryManager;

        public ResourceQueryService(IRepositoryManager repositoryManager) =>
            _repositoryManager = repositoryManager;

        public IEnumerable<ResourceDto> GetAllResources()
        {
           var resources=
                _repositoryManager.ResourceRepoManager.ResourceQueryRepositry.GetAll;
            var resourcesDto = resources.Adapt<IEnumerable<ResourceDto>>();

            return resourcesDto;
        }

        public ResourceDto GetResource(int id)
        {
            throw new NotImplementedException();
        }
    }
}
