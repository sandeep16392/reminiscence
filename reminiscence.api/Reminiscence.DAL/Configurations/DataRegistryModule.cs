using Autofac;
using Reminiscence.DAL.Abstraction;
using Reminiscence.DAL.Repositories;

namespace Reminiscence.DAL.Configurations
{
    public class DataRegistryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<GenreRepository>().As<IGenreRepository>();
        }
    }
}
