using Domain.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.ResourcesRepo
{
    public class ResourceCommandRepo : IResourceCommandRepositry
    {
        private readonly RepositoryDbContext _dbContext;
        public ResourceCommandRepo(RepositoryDbContext dbContext) => _dbContext = dbContext;
        public (bool sccuess, string message) Delete(Resource t)
        {
            throw new NotImplementedException();
        }

        public (int id, bool sccuess, string message) Save(Resource t)
        {
            _dbContext.Resources.Add(t);

            var resourceId = _dbContext.SaveChanges();


            return (resourceId, true, "Resource Saved ");
        }
    }
}
