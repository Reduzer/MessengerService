using System.Diagnostics;
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
using Viewer.PageTypes;


namespace Viewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string sMessage;
        private string sName;

        LiveChat liveChat;
        ProfilePage profilePage;
        ChatListPage chatListPage;
        ChatHeaderPage chatHeaderPage;

        public MainWindow(string name)
        {
            sName = name;

            InitializeComponent();

            onFirstLoad();
        }

        public void onFirstLoad()
        {
            liveChat = new LiveChat();
            profilePage = new ProfilePage();
            chatListPage = new ChatListPage();
            chatHeaderPage = new ChatHeaderPage();

            MainPage.Content = liveChat;
            ProfilePage.Content = profilePage;
            ChatListPage.Content = chatListPage;
            ChatHeaderPage.Content = chatHeaderPage;
        }

        private void Page_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                sMessage = liveChat.InputBox.Text;

                if (sMessage != String.Empty)
                {
                    liveChat.InputBox.Text = String.Empty;

                    liveChat.sendMessageToDisplay(sMessage, sName);
                }                
            }
        }

        public static void ShowMessageBox(string message)
        {
            MessageBox.Show(message);
        }
    }
}