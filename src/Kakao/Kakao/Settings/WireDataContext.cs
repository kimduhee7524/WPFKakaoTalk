using Jamesnet.Wpf.Global.Location;
using Kakao.Login.Local.ViewModels;
using Kakao.Login.UI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kakao.Settings
{
    // view와 viewModeld을 연결시켜주는 클래스
    internal class WireDataContext : ViewModelLocationScenario
    {
        protected override void Match(ViewModelLocatorCollection items)
        {
            items.Register<LoginContent, LoginContentViewModel>();
        }
    }
}
