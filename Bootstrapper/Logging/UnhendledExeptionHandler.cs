using System.Windows.Threading;
using NLog;

namespace Bootstrapper.Logging;

class UnhendledExeptionHandler : IUnhendledExeptionHandler
{
    private static readonly NLog.ILogger Logger = LogManager.GetLogger(nameof(UnhendledExeptionHandler));
    public void Handel(DispatcherUnhandledExceptionEventArgs e)
    {
        e.Handled = true;
        Logger.Error(e.Exception);
    }
}