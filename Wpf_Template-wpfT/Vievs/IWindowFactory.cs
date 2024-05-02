using VievModels.Windows;
using Vievs.Windows;

namespace Vievs;

public interface IWindowFactory
{
    IWindow Create<TWindowViewModel>(TWindowViewModel viewModel)
        where TWindowViewModel : IWindowViewModel;
}