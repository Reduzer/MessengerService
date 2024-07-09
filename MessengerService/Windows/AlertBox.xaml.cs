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
using System.Windows.Shapes;

namespace MessengerService.Windows
{
    /// <summary>
    /// Interaction logic for AlertBox.xaml
    /// </summary>
    public partial class AlertBox : Window
    {
        private string message;
        public AlertBox(string message)
        {
            InitializeComponent();

            this.message = message;

            this.TextForLabel.Content = this.message;
        }

        private void BtnYes_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.
            this.Close();
        }

        private void BtnNo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
