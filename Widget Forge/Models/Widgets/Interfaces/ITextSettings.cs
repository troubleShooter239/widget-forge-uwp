using Windows.UI;
using Windows.UI.Text;
using Windows.UI.Xaml.Media;

namespace Widget_Forge.Models.Widgets.Interfaces
{
    internal interface ITextSettings
    {
        Color ForegroundColor { get; set; }
        byte FontSize { get; set; }
        FontFamily Family { get; set; }
        FontWeight Weight { get; set; }
        FontStyle Style { get; set; }
    }
}
