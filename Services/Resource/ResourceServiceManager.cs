using Domain.Repositories;
using Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public sealed class ResourceServiceManager : IResourceServiceManager
    {
        private readonly Lazy<IResourceQueryService> _lazyResourceQueryService;
        private readonly Lazy<IResourceCommandService> _lazyResourceCommandService;
       
        public ResourceServiceManager(IRepositoryManager repositoryManager)
        {
            _lazyResourceQueryService = new Lazy<IResourceQueryService>(() => new ResourceQueryService(repositoryManager));
            _lazyResourceCommandService = new Lazy<IResourceCommandService>(() => new ResourceCommandService(repositoryManager));
        }
        public IResourceQueryService ResourceQueryService => _lazyResourceQueryService.Value;

        public IResourceCommandService ResourceCommandService => _lazyResourceCommandService.Value;
    }
}
