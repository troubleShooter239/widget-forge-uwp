using Widget_Forge.Models.Widgets.Interfaces;
using Windows.UI;
using Windows.UI.Text;
using Windows.UI.Xaml.Media;

namespace Widget_Forge.Models.Widgets
{
    internal class TimeWidget : Widget, ITextSettings, IFormatter
    {
        public bool ShowSeconds { get; set; } = true;
        public bool Is12HourFormat { get; set; } = false;

        public char Separator { get; set; } = ':';
        public Color ForegroundColor { get; set; }
        public byte FontSize { get; set; } = 24;
        public FontFamily Family { get; set; } = FontFamily.XamlAutoFontFamily;
        public FontWeight Weight { get; set; }
        public FontStyle Style { get; set; } = FontStyle.Normal;
    }
}
