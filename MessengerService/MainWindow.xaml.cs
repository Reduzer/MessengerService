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
        

        public MainWindow()
        {
            InitializeComponent();

            MessageBox.Show("TEST");
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
    }
}