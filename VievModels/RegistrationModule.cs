using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using VievModel.VievModels.MainWindow.ControlsVievModel;
using VievModels.VievModels.AboutWindowVievModel;
using VievModels.VievModels.MainWindow;
namespace VievModel
{
    public class RegistrationModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MainWindowVievModel>().As<IMainWindowVievModel>()
                .InstancePerDependency();
            builder.RegisterType<AboutVievModel>().As<IAboutWindowVievModel>()
                .InstancePerDependency();
            builder.RegisterType<MenuMainWindowVievModel>().As<IMenuMainWindowVievModel>().InstancePerDependency();
            base.Load(builder);
        }
    }
}
