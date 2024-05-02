using System.ComponentModel;

namespace Vievs.Windows;

public interface IWindow
{
    void Show();
    void Close();
    bool Activate();

    event CancelEventHandler Closing;
    event EventHandler Closed;
}