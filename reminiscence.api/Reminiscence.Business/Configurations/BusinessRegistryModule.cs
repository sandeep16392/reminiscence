using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using AutoMapper;
using Reminiscence.Business.Abstractions;
using Reminiscence.Business.AutoMapper;
using Reminiscence.Business.Services;
using Reminiscence.DAL.Configurations;

namespace Reminiscence.Business.Configurations
{
    public class BusinessRegistryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<PostRepository>().As<IPostRepository>();
            builder.RegisterModule(new DataRegistryModule());

            builder.Register(c => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new GenreMapper());

            })).AsSelf().SingleInstance();

            builder.Register(c => c.Resolve<MapperConfiguration>().CreateMapper(c.Resolve)).As<IMapper>().InstancePerLifetimeScope();
            //builder.Register<IMapper>(ctx => new Mapper(ctx.Resolve<IConfigurationProvider>(), ctx.Resolve)).InstancePerDependency();
            builder.RegisterType<GalleryService>().As<IGalleryService>();
        }
    }
}
