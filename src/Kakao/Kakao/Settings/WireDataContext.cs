﻿using Jamesnet.Wpf.Global.Location;
using Kakao.Chats.Local.ViewModels;
using Kakao.Chats.UI.Views;
using Kakao.Forms.Local.ViewModels;
using Kakao.Forms.UI.Views;
using Kakao.Friends.Local.ViewModels;
using Kakao.Friends.UI.Views;
using Kakao.Login.Local.ViewModels;
using Kakao.Login.UI.Views;
using Kakao.Main.Local.ViewModels;
using Kakao.Main.UI.Views;
using Kakao.More.UI.Views;
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
            items.Register<kakaoWindow, KakaoViewModel>();
            items.Register<LoginContent, LoginContentViewModel>();
            items.Register<MainContent, MainContentViewModel>();
            items.Register<FriendsContent, FriendsContentViewModel>();
            items.Register<ChatsContent, ChatsContentViewModel>();
            items.Register<MoreContent, ChatsContentViewModel>();
        }
    }
}
