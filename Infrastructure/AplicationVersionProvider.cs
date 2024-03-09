using Domain.Version;

namespace Infrastructure;

public class AplicationVersionProvider: IAplicationVersionProvider
{
    public Version Version { get; }=new Version(1,0,0);
}