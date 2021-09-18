using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IResource
    {
        IResourceQuery ResourceQuery { get; }
        IResourceCommand ResourceCommand { get; }
    }
}
