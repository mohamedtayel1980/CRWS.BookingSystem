using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstractions
{
   public interface IResourceServiceManager
    {
        IResourceQueryService   ResourceQueryService { get; }
        IResourceCommandService ResourceCommandService { get; }
    }
}
