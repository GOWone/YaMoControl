using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using YaMoControl.Models;

namespace YaMoControl.Views
{
    /// <summary>
    /// SideMenuDemo.xaml 的交互逻辑
    /// </summary>
    public partial class SideMenuDemo : Window
    {
        public ObservableCollection<ListItemModel> nameList = new ObservableCollection<ListItemModel>();
        public SideMenuDemo()
        {
            InitializeComponent();
            init();
            listTemp.ItemsSource = nameList;
        }

        public void init()
        {
            nameList.Add(new ListItemModel() {Index = 1, Name="123", Remark= "123"});
            nameList.Add(new ListItemModel() {Index = 1, Name="123", Remark= "123"});
            nameList.Add(new ListItemModel() {Index = 1, Name="123", Remark= "123"});
            nameList.Add(new ListItemModel() {Index = 1, Name="123", Remark= "123"});
            nameList.Add(new ListItemModel() {Index = 1, Name="123", Remark= "123"});
            nameList.Add(new ListItemModel() {Index = 1, Name="123", Remark= "123"});
            nameList.Add(new ListItemModel() {Index = 1, Name="123", Remark= "123"});
            nameList.Add(new ListItemModel() {Index = 1, Name="123", Remark= "123"});
        }
    }
}
