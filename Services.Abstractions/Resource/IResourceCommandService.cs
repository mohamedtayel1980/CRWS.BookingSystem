using Contracts;
using System.Collections.Generic;

namespace Services.Abstractions
{
    public interface IResourceCommandService
    {
        public (int id, bool sccuess, string message) Save(ResourceDto resourceDto);
        public (bool sccuess, string message) Delete(ResourceDto resourceDto);
    }
}
