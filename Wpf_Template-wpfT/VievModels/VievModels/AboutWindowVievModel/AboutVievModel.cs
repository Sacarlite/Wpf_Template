using Domain.Settings;
using VievModel.Windows;
using VievModels.VievModels.AboutWindowVievModel;

namespace VievModels.VievModels.AboutWindowVievModel;

public class AboutVievModel:WindowVievModel<IAboutWindowMementoWrapper>,IAboutWindowVievModel
{
    public AboutVievModel(IAboutWindowMementoWrapper windowMementoWrapper) : base(windowMementoWrapper)
    {
    }
}