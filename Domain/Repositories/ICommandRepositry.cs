using Contracts;
using Domain.Entities;

namespace Domain.Repositories
{
    public interface ICommandRepositry<T> where T : BaseEntity
    {
        public Result Save(T t);
        public Result Delete(T t);
    }
}
