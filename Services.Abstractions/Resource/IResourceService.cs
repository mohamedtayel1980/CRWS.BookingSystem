﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstractions
{
   public interface IResourceService
    {
        IResourceQueryService   ResourceQueryService { get; }
        IResourceCommandService ResourceCommandService { get; }
    }
}
