using System.IO;
using Bootstrapper.Common;
using Domain.Settings;
using Newtonsoft.Json;
namespace Infrastructure.Settings;

internal abstract class WindowMementoWrapper<TMemento> : IWindowMementoWrapperInitializer, IWindowMementoWrapper,
    IDisposable
    where TMemento : WindowMemento, new()
{
    private bool _initialized;
    private TMemento _memento;
    private readonly IPathService _pathService;
    private string? _settingsFilePath;

    protected WindowMementoWrapper(IPathService pathService)
    {
        _pathService = pathService;
        _memento = new TMemento();
    }

    protected abstract string MementoName { get; }

    public void Dispose()
    {
        EnsureInitialized();
        var serializedMemento = JsonConvert.SerializeObject(_memento);
        if (_settingsFilePath is not null)
        {
            File.WriteAllText(_settingsFilePath, serializedMemento);
        }
    }


    public double Left
    {
        get
        {
            EnsureInitialized();
            return _memento.Left;
        }
        set
        {
            EnsureInitialized();
            _memento.Left = value;
        }
    }

    public double Top
    {
        get
        {
            EnsureInitialized();
            return _memento.Top;
        }
        set
        {
            EnsureInitialized();
            _memento.Top = value;
        }
    }

    public double Width
    {
        get
        {
            EnsureInitialized();
            return _memento.Width;
        }
        set
        {
            EnsureInitialized();
            _memento.Width = value;
        }
    }

    public double Height
    {
        get
        {
            EnsureInitialized();
            return _memento.Height;
        }
        set
        {
            EnsureInitialized();
            _memento.Height = value;
        }
    }

    public bool IsMaximized
    {
        get
        {
            EnsureInitialized();
            return _memento.IsMaximized;
        }
        set
        {
            EnsureInitialized();
            _memento.IsMaximized = value;
        }
    }

    public void initialize()
    {
        if (_initialized)
            throw new InvalidOperationException(
                $"Wrapper for {typeof(TMemento)} is already initialized");

        _initialized = true;


        const string settings = "Settings";
        var settingsPath = Path.Combine(_pathService.ApplicationFolder, settings);
        _settingsFilePath = Path.Combine(settingsPath, $"{MementoName}.json");
        Directory.CreateDirectory(settingsPath);
        if (!File.Exists(_settingsFilePath)) return;

        var serializedMemento = File.ReadAllText(_settingsFilePath);
        _memento = JsonConvert.DeserializeObject<TMemento>(serializedMemento) ?? throw new InvalidOperationException("Deserialized memento can't be null"); ;
    }

    private void EnsureInitialized()
    {
        if (!_initialized)
            throw new InvalidOperationException($"Wrapper for {typeof(TMemento)} is not initialized");
    }
}