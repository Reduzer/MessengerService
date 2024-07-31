using MessengerService;
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
using MessengerService.Windows;

namespace MessengerService
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly string? _sAlertMessage = Properties.Settings.Default.AlertBoxText;
        private readonly string? _sNoLoginStartMessage = Properties.Settings.Default.InfoBoxText;

        private string? _sName;
        private string? _sPassword;

        private bool _fullLogin;

        //Needed Objects for the Login proccess
        private Viewer.MainWindow? _newForm;
        private AlertBox? _alertBox;
        private Login.Login login;

        /// <summary>
        /// Default constructor for the start of the program
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            login = new Login.Login();
        }


        /// <summary>
        /// Checks for the way of logging into the program
        /// </summary>
        /// <returns>Bool</returns>
        private bool logIn()
        {
            if (login.LoginClient(_sName, _sPassword))
            {
                Debug.WriteLine("Name: " + _sName + " Password: " + _sPassword);
                _fullLogin = true;
                return true;
            }

            if (TextBoxName.Text != String.Empty && TextBoxPassword.Password == String.Empty)
            {
                _fullLogin = false;
                return true;
            }

            if (TextBoxName.Text == String.Empty && TextBoxPassword.Password == String.Empty)
            {
                _alertBox = new AlertBox(_sAlertMessage);
                _alertBox.Show();
                _alertBox.Focus();
                return false;
            
            }

            if (TextBoxName.Text != String.Empty && TextBoxPassword.Password == String.Empty)
            {
                _fullLogin = false;
                return true;
            }

            return false;
        }


        /// <summary>
        /// Gets the input from the user
        /// </summary>
        private void getInput()
        {
            string name = TextBoxName.Text;
            string password = TextBoxPassword.Password;

            _sName = name;
            _sPassword = password;
        }


        /// <summary>
        /// Event, welches aufgerufen wird, wenn der Nutzer sich anmelden will. Wenn der login erfolgreich ist, wird das Chat fenster geöffnet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {   
            getInput();

            if (logIn())
            {
                DisposeObjects();

                _newForm = new Viewer.MainWindow(_sName, _fullLogin);
                _newForm.Show();

                this.Close();
            }
        }

        /// <summary>
        /// Method for calling the Window for handling the forgot password feature
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ForgotPasswordButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Work in Progress");
        }

        /// <summary>
        /// Method for catching the user pressing a button while focusing the login window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                LoginButton_Click(null, null);
            }
        }

        /// <summary>
        /// Method for moving the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        /// <summary>
        /// Method for closing the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Method for minimizing the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinimizeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void DisposeObjects()
        {
            _alertBox = null;
            login = null;

            return;
        }
    }
}