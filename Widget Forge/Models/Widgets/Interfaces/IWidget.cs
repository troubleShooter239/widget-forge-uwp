using Widget_Forge.Enums;
using Windows.UI;

namespace Widget_Forge.Models.Widgets.Interfaces
{
    internal interface IWidget
    {
        string Name { get; set; }
        Position Position { get; set; }
        Size Size { get; set; }
        WidgetType Type { get; set; }
        bool IsMovable { get; set; }
        bool IsAlwaysOnTop { get; set; }
        bool IsClickable { get; set; }
        Color BackgroundColor { get; set; }
        byte CornerRadius { get; set; }
    }
}
