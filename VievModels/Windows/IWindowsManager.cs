using Vievs.Windows;

namespace VievModels.Windows;

public interface IWindowManager
{
    IWindow Show<TWindowVievModel>(TWindowVievModel windowVievModel)
        where TWindowVievModel : IWindowViewModel;
    void Close<TWindowVievModel>(TWindowVievModel windowVievModel)
        where TWindowVievModel : IWindowViewModel;
}