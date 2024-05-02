using System.Windows.Threading;

namespace Bootstrapper.Logging;

public interface IUnhendledExeptionHandler
{
    void Handel(DispatcherUnhandledExceptionEventArgs e);
}