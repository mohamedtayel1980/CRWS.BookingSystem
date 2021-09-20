using Contracts;
using System.Collections.Generic;

namespace Services.Abstractions
{
    public interface IResourceCommandService
    {
        public Result Save(ResourceDto resourceDto);
        public Result Delete(ResourceDto resourceDto);
    }
}
