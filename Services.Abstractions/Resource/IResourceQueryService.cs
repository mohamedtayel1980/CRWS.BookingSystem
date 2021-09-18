using Contracts;
using System;
using System.Collections.Generic;

namespace Services.Abstractions
{
    public interface IResourceQueryService
    {
        ResourceDto GetResource(int id);
        IEnumerable<ResourceDto> GetAllResources();
    }
}
