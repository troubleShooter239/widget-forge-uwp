using Widget_Forge.Models.Widgets.Interfaces;
using Widget_Forge.Enums;
using Windows.UI;

namespace Widget_Forge.Models.Widgets
{
    internal class Widget : IWidget
    {
        public string Name { get; set; } = "New widget";
        public Position Position { get; set; } = Position.GetCenterOfScreen();
        public Size Size { get; set; } = new Size(){ W = 300, H = 150 };
        public WidgetType Type { get; set; }
        public bool IsMovable { get; set; } = true;
        public bool IsAlwaysOnTop { get; set; } = false;
        public bool IsClickable { get; set; } = true;
        public Color BackgroundColor { get; set; } = Color.FromArgb(255, 255, 255, 255);
        public byte CornerRadius { get; set; } = 30;
    }
}
