using Autofac;

namespace reminiscence.api.Configurations
{
    public class ApiRegistryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<PostRepository>().As<IPostRepository>();
        }
    }
}
