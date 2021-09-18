using Domain.Entities;

namespace Domain.Repositories
{
    public interface ICommandRepositry<T> where T : BaseEntity
    {
        public (int id, bool sccuess, string message) Save(T t);
        public (bool sccuess, string message) Delete(T t);
    }
}
