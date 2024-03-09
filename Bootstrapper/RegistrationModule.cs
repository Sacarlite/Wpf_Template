using Application.Factory;
using Autofac;
using Domain.Factories;
using Vievs;

namespace Application;

public class RegistrationModule:Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<WindowFactory>().As<IWindowFactory>().SingleInstance();
        builder.RegisterGeneric(typeof(Factory<>)).As(typeof(IFactory<>)).SingleInstance();
        base.Load(builder);
    }
}