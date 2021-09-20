using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IResourceQueryRepositry : 
        IQueryRepositry<Resource>
    {
        IEnumerable<Booking> GetAllResourceBookingDates(int id);
    }
}
