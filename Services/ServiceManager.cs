using Domain.Repositories;
using Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IResourceServiceManager> _lazyResourceServiceManager;
        public ServiceManager(IRepositoryManager repositoryManager)
        {
            _lazyResourceServiceManager = new Lazy<IResourceServiceManager>(() => new ResourceServiceManager(repositoryManager));
        }
        public IResourceServiceManager ResourceService => _lazyResourceServiceManager.Value;
    }
}
