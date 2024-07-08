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

namespace MessengerService
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private unsafe string sName;
        private unsafe string sPassword;

        private bool fullLogin;

        Viewer.MainWindow newForm;

        private Login.Login login;

        public MainWindow()
        {
            InitializeComponent();
            login = new Login.Login();
        }


        /// <summary>
        /// Hier werden die verschiedenen Login möglichkeiten einmal überprüft
        /// </summary>
        /// <returns>Bool</returns>
        private bool logIn()
        {
            if (TextBoxName.Text == String.Empty && TextBoxPassword.Password == String.Empty)
            {
                MessageBox.Show("Du hast keinen Namen angegeben, wenn du dich nicht anmelden willst, gebe bitte einen Namen an und klicke dann auf anmelden");
                
                return false;
            
            }

            if (TextBoxName.Text != String.Empty && TextBoxPassword.Password == String.Empty)
            {
                MessageBox.Show("Du wirst nun ohne Anmeldung weitergeleitet");
                fullLogin = false;
                return true;
            }

            if(login.LogInClient(sName, sPassword))
            {
                Debug.WriteLine("Name: " + sName + " Password: " + sPassword);
                fullLogin = true;
                return true;
            }
            return false;
        }


        /// <summary>
        /// Holt sich die Eingaben des Nutzers
        /// </summary>
        private void getInput()
        {
            string name = TextBoxName.Text;
            string password = TextBoxPassword.Password;

            sName = name;
            sPassword = password;
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
                newForm = new Viewer.MainWindow(sName, fullLogin);
                newForm.Show();
                this.Close();
            }
        }

        private void ForgotPasswordButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Work in Progress");
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                LoginButton_Click(null, null);
            }
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Closebtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Minimizebtn_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}