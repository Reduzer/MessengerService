using MessengerService.Objects;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Viewer;

namespace MessengerService
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private unsafe string* pName;
        private unsafe string* pPassword;

        private unsafe user user;

        Viewer.MainWindow newForm;

        public MainWindow()
        {
            InitializeComponent();
        }

        private unsafe bool logIn(string name, string password)
        {
            *pName = name;
            *pPassword = password;

            user = new user(pName, pPassword) ;

            if (user.login())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            newForm = new Viewer.MainWindow();
            newForm.Show();
            this.Hide();
        }
    }
}