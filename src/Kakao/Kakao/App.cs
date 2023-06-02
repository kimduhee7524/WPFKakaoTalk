using Jamesnet.Wpf.Controls;
using Kakao.Forms.UI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Kakao
{
    internal class App: JamesApplication
    {
        protected override Window CreateShell()
        {
            return new kakaoWindow();
        }

    }
}
