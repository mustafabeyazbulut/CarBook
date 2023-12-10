
namespace Carbook.Application.Features.RepositoryPattern
{
    public interface IGenericRepository<T> where T : class
    {
        List<T> GetAll();
        void Create(T item);
        void Update(T item);
        void Remove (T item);
        T GetById (int id);

    }
}
