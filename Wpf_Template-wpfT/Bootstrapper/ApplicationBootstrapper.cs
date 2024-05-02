using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application;
using Bootstrapper.Common;
using Bootstrapper.Logging;
namespace Bootstrapper
{
    public class ApplicationBootstrapper:IDisposable
    {
        private readonly IContainer _container;
        public ApplicationBootstrapper()
        {
            var containerBuilder = new ContainerBuilder();
            RegisterDependencies(containerBuilder);
            _container = containerBuilder.Build();
            InitializeDependencies();
        }

        private void InitializeDependencies()
        {
            _container.Resolve<IPathServiceInitializer>().Initialize();
            _container.Resolve<ILogManagerInitializer>();
        
        }

        private void RegisterDependencies(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<Application.Application>().As<IApplication>().SingleInstance();
            containerBuilder.RegisterType<UnhendledExeptionHandler>().As<IUnhendledExeptionHandler>().SingleInstance();
            containerBuilder.RegisterType<PathService>().As<IPathService>().As<IPathServiceInitializer>().SingleInstance();
            containerBuilder.RegisterType<LogManagerInitializer>().As<ILogManagerInitializer>().SingleInstance();
        }

        public IApplication CreateApplication()
        {
            return _container.Resolve<IApplication>();
        }

        public IUnhendledExeptionHandler CreateUnhendledExeptionHandler()
        {
            return
            _container.Resolve<IUnhendledExeptionHandler>();
        }
        public void Dispose()
        {
          _container.Dispose();
        }
    }
}
