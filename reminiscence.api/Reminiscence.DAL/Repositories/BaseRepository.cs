using System.Threading.Tasks;
using Reminiscence.DAL.Abstraction;
using Reminiscence.DAL.Data;

namespace Reminiscence.DAL.Repositories
{
    public class BaseRepository : IBaseRepository
    {
        protected readonly DataContext Context;

        public BaseRepository(DataContext context)
        {
            if (Context == null)
                Context = context;
        }
        public void Add<T1>(T1 entity) where T1 : class
        {
            Context.Add(entity);
        }

        public void Delete<T1>(T1 entity) where T1 : class
        {
            Context.Remove(entity);
        }

        public async Task<bool> SaveAll()
        {
            return await Context.SaveChangesAsync() > 0;
        }
    }
}
