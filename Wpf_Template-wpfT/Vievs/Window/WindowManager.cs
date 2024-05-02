
using System.ComponentModel;
using VievModels.Windows;
using Vievs;
using Vievs.Windows;

namespace Vievs.Window;

internal class WindowManager : IWindowManager
{
    private readonly Dictionary<IWindowViewModel, IWindow> _viewModelToWindowMap = new();
    private readonly IWindowFactory _windowFactory;
    private readonly Dictionary<IWindow, IWindowViewModel> _windowToViewModelMap = new();

    public WindowManager(IWindowFactory windowFactory)
    {
        _windowFactory = windowFactory;
    }

    public IWindow Show<TWindowVievModel>(TWindowVievModel windowVievModel) where TWindowVievModel : IWindowViewModel
    {
        if (_viewModelToWindowMap.TryGetValue(windowVievModel, out var window))
        {
           window.Activate();

            return window;
        }

        window = _windowFactory.Create(windowVievModel);

        _viewModelToWindowMap.Add(windowVievModel, window);
        _windowToViewModelMap.Add(window, windowVievModel);

        window.Closing += OnWindowClosing;
        window.Closed += OnWindowClosed;

        window.Show();

        return window;
    }

    public void Close<TWindowVievModel>(TWindowVievModel windowVievModel) where TWindowVievModel : IWindowViewModel
    {
        if (_viewModelToWindowMap.TryGetValue(windowVievModel, out var  window))
            window.Close();
    }
    private void OnWindowClosed(object? sender, EventArgs e)
    {
        if (sender is IWindow window && _windowToViewModelMap.TryGetValue(window, out var viewModel))
        {
            window.Closing -= OnWindowClosing;
            window.Closed -= OnWindowClosed;

            _viewModelToWindowMap.Remove(viewModel);
            _windowToViewModelMap.Remove(window);
        }
    }

    private void OnWindowClosing(object? sender, CancelEventArgs e)
    {
        if (sender is IWindow window && _windowToViewModelMap.TryGetValue(window, out var viewModel))
            viewModel.WindowClosing();
    }
}