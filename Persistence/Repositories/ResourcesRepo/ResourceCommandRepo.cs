using Domain.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;

namespace Persistence.Repositories.ResourcesRepo
{
    internal sealed class ResourceCommandRepo : IResourceCommandRepositry
    {
        private readonly RepositoryDbContext _dbContext;
        public ResourceCommandRepo(RepositoryDbContext dbContext) => _dbContext = dbContext;

        public Result Delete(Resource t)
        {
            throw new NotImplementedException();
        }

        public Result Save(Resource resource)
        {

            _dbContext.Resources.Add(resource);
            var result = new Result
            {
                objectId = _dbContext.SaveChanges(),
                message = $"Resource  saved sccuessfuly",
                status = true
            };

            return result;
        }

        public Result SaveBooking(Booking booking)
        {
           //TODO:Add validation

            _dbContext.Bookings.Add(booking);
            var result = new Result
            {
                objectId = _dbContext.SaveChanges(),
                message = $"Resource  saved sccuessfuly",
                status = true
            };

            return result;
        }
    }
}
