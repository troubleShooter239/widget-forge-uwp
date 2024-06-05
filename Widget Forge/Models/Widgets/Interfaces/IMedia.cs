using Windows.UI.Xaml.Media;

namespace Widget_Forge.Models.Widgets.Interfaces
{
    internal interface IMedia
    {
        Stretch Stretch { get; set; }
        bool IsTextVisible { get; set; }
        string Text { get; set; }
        string MediaFolder { get; set; }
        bool IsRandomPlaying { get; set; }
        float Delay { get; set; }
    }
}
