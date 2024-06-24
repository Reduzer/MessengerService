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

namespace Viewer.PageTypes
{
    /// <summary>
    /// Interaction logic for LiveChat.xaml
    /// </summary>
    public partial class LiveChat : Page
    {
        public LiveChat()
        {
            InitializeComponent();
        }

        public void sendMessageToDisplay(string msg, string name)
        {
            ChatViewListBox.Items.Add(name +": " + msg);
        }
    }
}
