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
using Login;

namespace MessengerService
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private unsafe string* pName;
        private unsafe string* pPassword;

        Viewer.MainWindow newForm;

        private Login.Login login;

        public MainWindow()
        {
            InitializeComponent();
            login = new Login.Login();
        }



        private unsafe bool logIn()
        {
            MessageBox.Show("Login Called");
            if(login.LogInClient(pName, pPassword))
            {
                MessageBox.Show("");
                return true;
            }
            return false;
        }

        private unsafe void getInput()
        {
            string name = TextBoxName.Text;
            string password = TextBoxPassword.Text;

            pName = &name;
            pPassword = &password;
        }


        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            getInput();

            if (logIn())
            {
                newForm = new Viewer.MainWindow();
                newForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Your inputs are invalid, please check");
            }
        }
    }
}