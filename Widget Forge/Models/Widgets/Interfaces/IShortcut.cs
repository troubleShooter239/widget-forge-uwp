namespace Widget_Forge.Models.Widgets.Interfaces
{
    internal interface IShortcut
    {
        string ShortcutName { get; set; }
        bool IsNameVisible { get; set; }
        string Icon { get; set; }
        bool IsIconVisible { get; set; }
    }
}
