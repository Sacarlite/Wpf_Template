using Domain.Factories;
using Domain.Settings;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VievModel.VievModels.MainWindow.ControlsVievModel;
using VievModel.Windows;
using VievModels.VievModels.AboutWindowVievModel;
using VievModels.VievModels.MainWindow;
using VievModels.Windows;

namespace VievModel.VievModels.AutorizationVievModel
{
    public class AutorizationVievModel : WindowVievModel<IAutorizationWindowMementoWrapper>, IAboutWindowVievModel
    {
        private  IAutorizationWindowMementoWrapper windowMementoWrapper;
        private readonly IWindowManager windowManager;
        private readonly IFactory<IMainWindowVievModel> mainWindowVievModelFactory;

        public AutorizationVievModel(IAutorizationWindowMementoWrapper windowMementoWrapper,
             IWindowManager windowManager, IFactory<IMainWindowVievModel> MainWindowVievModelFactory) : base(windowMementoWrapper)
        {
            this.windowMementoWrapper = windowMementoWrapper;
            this.windowManager = windowManager;
            mainWindowVievModelFactory = MainWindowVievModelFactory;
        }
    }
}
