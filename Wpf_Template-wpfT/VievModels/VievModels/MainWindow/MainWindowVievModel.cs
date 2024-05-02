using Domain.Factories;
using Domain.Settings;
using Domain.Version;
using VievModel.VievModels.MainWindow.ControlsVievModel;
using VievModel.Windows;
using VievModels.Windows;

namespace VievModels.VievModels.MainWindow;

public class MainWindowVievModel : WindowVievModel<IMainWindowMementoWrapper>, IMainWindowVievModel
{
    private readonly IAplicationVersionProvider _aplicationVersionProvider;
    private readonly IWindowManager _windowManager;
    private IMainWindowMementoWrapper _windowMementoWrapper;
   public MainWindowVievModel(IMainWindowMementoWrapper mainWindowMementoWrapper,
        IWindowManager windowManager, IFactory<IMenuMainWindowVievModel> MenueMainWindowVievModelFactory,
        IAplicationVersionProvider aplicationVersionProvider)
        : base(mainWindowMementoWrapper)
    {
        MenuMainWindowVievModel = MenueMainWindowVievModelFactory.Create();
        _windowManager = windowManager;
        _aplicationVersionProvider = aplicationVersionProvider;
        _windowMementoWrapper = mainWindowMementoWrapper;
    }

    public IMenuMainWindowVievModel MenuMainWindowVievModel { get; set; }


    public string Version => $"Version {_aplicationVersionProvider.Version.ToString(3)}";

    public string Title => "TODO YorTitle";

    public override void WindowClosing()
    {
        MenuMainWindowVievModel.CloseAboutWindow();
    }

    public void Dispose()
    {
        MenuMainWindowVievModel.Dispose();
    }
}