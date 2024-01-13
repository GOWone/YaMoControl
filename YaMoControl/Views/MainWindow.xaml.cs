using System.Windows;
using YaMoControlDesign.Controls;

namespace YaMoControl.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Growl.Info("This is a Test");
        }
    }
}
