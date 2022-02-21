using BookShop.ViewModel;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BookShop.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            ViewModel = new MainViewModel();
            this.DataContext = ViewModel;
        }

        public object ViewModel { get; }

        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            ComboBox mybox = new ComboBox();
            mybox.Background = new SolidColorBrush(Colors.Red);
            mybox.FontSize = 30;
            //mybox.
            mybox.Visibility = Visibility.Visible;
           
        }
    }
}
