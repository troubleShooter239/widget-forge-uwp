using Widget_Forge.Models.Widgets.Interfaces;

namespace Widget_Forge.Models.Widgets
{
    internal class ShortcutWidget : Widget, IShortcut
    {
        public string ShortcutName { get; set; }
        public bool IsNameVisible { get; set; }
        public string Icon { get; set; }
        public bool IsIconVisible { get; set; }
    }
}
