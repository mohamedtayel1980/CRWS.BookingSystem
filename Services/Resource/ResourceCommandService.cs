using Contracts;
using Domain.Entities;
using Domain.Repositories;
using Mapster;
using Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    internal sealed class ResourceCommandService : IResourceCommandService
    {
        private readonly IRepositoryManager _repositoryManager;
        public ResourceCommandService(IRepositoryManager repositoryManager)=>
            _repositoryManager = repositoryManager;
        public Result Delete(ResourceDto resourceDto)
        {
            var resource = resourceDto.Adapt<Resource>();
          return  _repositoryManager.ResourceRepoManager.
                ResourceCommandRepositry.Delete(resource);
        }

        public Result Save(ResourceDto resourceDto)
        {
            throw new NotImplementedException();
            //var resource= resourceDto.Adapt<Resource>();
            //_repositoryManager.
        }
    }
}
