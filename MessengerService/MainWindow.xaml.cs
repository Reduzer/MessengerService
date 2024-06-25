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
using System.Diagnostics;

namespace MessengerService
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private unsafe string sName;
        private unsafe string sPassword;

        Viewer.MainWindow newForm;

        private Login.Login login;

        public MainWindow()
        {
            InitializeComponent();
            login = new Login.Login();
        }

        private bool logIn()
        {
            if (TextBoxName.Text == String.Empty || TextBoxPassword.Password == String.Empty)
            {
                return false;
            }

            if(login.LogInClient(sName, sPassword))
            {
                Debug.WriteLine("Name: " + sName + " Password: " + sPassword);
                return true;
            }
            return false;
        }

        private void getInput()
        {
            string name = TextBoxName.Text;
            string password = TextBoxPassword.Password;

            sName = name;
            sPassword = password;
        }


        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            getInput();

            if (logIn())
            {
                newForm = new Viewer.MainWindow();
                newForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Your inputs are invalid, please check");
            }
        }

        private void ForgotPasswordButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Work in Progress");
        }
    }
}