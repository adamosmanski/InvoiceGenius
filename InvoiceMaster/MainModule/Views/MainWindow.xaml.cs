using InvoiceMaster.MainModule.ViewModels;
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
using MahApps.Metro.Controls;

namespace InvoiceMaster.MainModule
{
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainViewModel();
            
        }

        private void CloseApp_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void MinimizeApp_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState != WindowState.Minimized)
            {
                WindowState = WindowState.Minimized;
            }
        }
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }
    }
}
