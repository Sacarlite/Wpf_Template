using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using VievModels.Windows;
using Vievs.Window;
using Vievs.Windows.AboutWindow;
using Vievs.Windows.MainWindow;

namespace Vievs
{
    public class RegistrationModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MainWindow.MainWindow>().As<IMainWindow>().InstancePerDependency();
            builder.RegisterType<Windows.AboutWindow.AboutWindow>().As<IAboutWindow>().InstancePerDependency();
            builder.RegisterType<WindowManager>().As<IWindowManager>().InstancePerDependency();

            base.Load(builder);
        }
    }
}
