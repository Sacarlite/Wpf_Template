using System.Runtime.Serialization;

namespace Infrastructure.Settings.DefaultMementas;
[DataContract]
internal class MainWindowMemento : WindowMemento
{
    public MainWindowMemento()
    {
        Left = 100;
        Top = 100;
        Width = 600;
        Height = 400;
        IsMaximized = true;
    }

}