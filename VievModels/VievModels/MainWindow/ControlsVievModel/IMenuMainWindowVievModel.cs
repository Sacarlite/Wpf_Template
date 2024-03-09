using System.Windows.Input;

namespace VievModel.VievModels.MainWindow.ControlsVievModel;

public interface IMenuMainWindowVievModel:IDisposable
{
    ICommand OpenAboutWindowCommand { get; }
    void CloseAboutWindow();
}