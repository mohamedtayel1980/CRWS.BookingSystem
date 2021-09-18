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
    public class ResourceCommandService : IResourceCommandService
    {
        private readonly IRepositoryManager _repositoryManager;
        public ResourceCommandService(IRepositoryManager repositoryManager)=> _repositoryManager = repositoryManager;
        public (bool sccuess, string message) Delete(ResourceDto resourceDto)
        {
            throw new NotImplementedException();
        }

        public (int id, bool sccuess, string message) Save(ResourceDto resourceDto)
        {
            throw new NotImplementedException();
            //var resource= resourceDto.Adapt<Resource>();
            //_repositoryManager.
        }
    }
}
