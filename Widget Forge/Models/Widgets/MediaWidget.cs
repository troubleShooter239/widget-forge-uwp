using Widget_Forge.Models.Widgets.Interfaces;
using Windows.UI.Xaml.Media;

namespace Widget_Forge.Models.Widgets
{
    internal class MediaWidget : Widget, IMedia
    {
        public Stretch Stretch { get; set; } = Stretch.None;
        public bool IsTextVisible { get; set; } = true;
        public string Text { get; set; } = "My media";
        public string MediaFolder { get; set; }
        public bool IsRandomPlaying { get; set; } = false;
        public float Delay { get; set; } = 5.0f;
    }
}
