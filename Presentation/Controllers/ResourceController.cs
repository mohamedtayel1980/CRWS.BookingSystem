using Microsoft.AspNetCore.Mvc;
using Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/resource/")]
    public class ResourceController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public ResourceController(IServiceManager serviceManager)
            => _serviceManager = serviceManager;

        [HttpGet]
        public IActionResult GetResource()
        {
            var resourcesDto =  _serviceManager.ResourceService.ResourceQueryService
                .GetAllResources();

            return Ok(resourcesDto);
        }
    }
}
