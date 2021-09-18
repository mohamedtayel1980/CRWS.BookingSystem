using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    public sealed class ResourceNotAvailableException : BadRequestException
    {
        public ResourceNotAvailableException(string resourceName,int quantity) 
            : base($"Resource {resourceName} with {quantity} not avaliable  ")
        {
        }
    }
}
