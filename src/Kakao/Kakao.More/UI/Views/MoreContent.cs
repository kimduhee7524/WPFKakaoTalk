using Jamesnet.Wpf.Controls;
using Kakao.More.Local.ViewModels;
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

namespace Kakao.More.UI.Views
{
    public class MoreContent : JamesContent
    {
        static MoreContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MoreContent), new FrameworkPropertyMetadata(typeof(MoreContent)));
        }

        public MoreContent()
        {

        }
    }
}
