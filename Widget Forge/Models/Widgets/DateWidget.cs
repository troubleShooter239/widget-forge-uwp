using Widget_Forge.Models.Widgets.Interfaces;

namespace Widget_Forge.Models.Widgets
{
    internal class DateWidget : Widget, IFormatter
    {
        public string Format { get; set; }
        public char Separator { get; set; } = '/';
    }
}
