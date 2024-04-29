using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Widget_Forge
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage() => InitializeComponent();
        
        private void CloudSavesButton_Click(object sender, RoutedEventArgs e) =>
            (Window.Current.Content as Frame)
                .Navigate(typeof(LoginPage));
    }
}
