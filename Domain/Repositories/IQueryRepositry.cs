using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IQueryRepositry<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll { get; }
        T Get(int id);
    }
}
