using Jamesnet.Wpf.Controls;
using Kakao.Chats.Local.ViewModels;
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

namespace Kakao.Chats.UI.Views
{
    public class ChatsContent : JamesContent
    {
        static ChatsContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ChatsContent), new FrameworkPropertyMetadata(typeof(ChatsContent)));
        }

        public ChatsContent()
        {

        }
    }
}
