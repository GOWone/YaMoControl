using System.Collections.Generic;
using System.Windows;
using YaMoControl.Models;
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
            init();
            ListViewTest.ItemsSource = listItemModels;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Growl.Info("This is a Test");
        }

        List<ListItemModel> listItemModels = new List<ListItemModel>();
        private void init() { 
            listItemModels.Add(new ListItemModel() { Index = 1, Name = "Test", Remark = "Test"});
            listItemModels.Add(new ListItemModel() { Index = 2, Name = "Test", Remark = "Test"});
            listItemModels.Add(new ListItemModel() { Index = 3, Name = "Test", Remark = "Test"});
            listItemModels.Add(new ListItemModel() { Index = 4, Name = "Test", Remark = "Test"});
            listItemModels.Add(new ListItemModel() { Index = 5, Name = "Test", Remark = "Test"});
            listItemModels.Add(new ListItemModel() { Index = 6, Name = "Test", Remark = "Test"});
            listItemModels.Add(new ListItemModel() { Index = 7, Name = "Test", Remark = "Test"});
            listItemModels.Add(new ListItemModel() { Index = 8, Name = "Test", Remark = "Test"});
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SideMenuDemo sideMenuDemo = new SideMenuDemo();
            sideMenuDemo.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            HamburgerMenuDemo sideMenuDemo = new HamburgerMenuDemo();
            sideMenuDemo.Show();
        }
    }
}
