using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.ResourcesRepo
{
    internal sealed class ResourceQueryRepo : IResourceQueryRepositry
    {
        private readonly RepositoryDbContext _dbContext;
        public ResourceQueryRepo(RepositoryDbContext dbContext) => _dbContext = dbContext;
        
        public IEnumerable<Resource> GetAll => _dbContext.Resources.ToList();

        public Resource Get(int id) => _dbContext.Resources.FirstOrDefault(x=>x.Id==id);

        public IEnumerable<Booking> GetAllResourceBookingDates(int id)
            =>_dbContext.Bookings.Where(x=>x.ResourceId==id);
        
    }
}
