using Windows.UI.ViewManagement;
namespace Widget_Forge.Models
{
    internal struct Position
    {
        public int X;
        public int Y;
        public static Position GetCenterOfScreen()
        {
            Windows.Foundation.Rect bounds = ApplicationView.GetForCurrentView().VisibleBounds;
            return new Position { X = (int)bounds.Width / 2, Y = (int)bounds.Height / 2 };
        }
    }
}
