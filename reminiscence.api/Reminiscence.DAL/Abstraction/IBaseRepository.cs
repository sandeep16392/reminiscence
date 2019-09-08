using System.Threading.Tasks;

namespace Reminiscence.DAL.Abstraction
{
    public interface IBaseRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAll();
    }
}
