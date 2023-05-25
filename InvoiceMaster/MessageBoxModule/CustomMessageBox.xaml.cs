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

namespace InvoiceMaster.MessageBoxModule
{
    /// <summary>
    /// Logika interakcji dla klasy CustomMessageBox.xaml
    /// </summary>
    public partial class CustomMessageBox : MetroWindow
    {
        public CustomMessageBox()
        {
            InitializeComponent();
            this.DataContext = new CustomMessageBoxViewModel("");
        }

        private void CloseApp_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void MinimizeApp_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState != WindowState.Minimized)
            {
                this.WindowState = WindowState.Minimized;
            }
        }

        private void MetroWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
