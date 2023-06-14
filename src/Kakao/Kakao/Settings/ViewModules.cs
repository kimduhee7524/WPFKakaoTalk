using Jamesnet.Wpf.Controls;
using Kakao.Chats.UI.Views;
using Kakao.Core.Names;
using Kakao.Friends.UI.Views;
using Kakao.Login.UI.Views;
using Kakao.Main.UI.Views;
using Kakao.More.UI.Views;
using Prism.Ioc;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kakao.Settings
{
    internal class ViewModules : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //프리즘 애플리케이션이 돌고있는 윈도우에서는 어디서든 LoginContent 문자열 하나만으로도 IViewable를 상속받는 LoginConent를 땡겨올 수 있음
            containerRegistry.RegisterSingleton<IViewable, LoginContent>(ContentNameManager.Login);
            containerRegistry.RegisterSingleton<IViewable, MainContent>(ContentNameManager.Main);
            containerRegistry.RegisterSingleton<IViewable, FriendsContent>(ContentNameManager.Friends);
            containerRegistry.RegisterSingleton<IViewable, ChatsContent>(ContentNameManager.Chats);
            containerRegistry.RegisterSingleton<IViewable, MoreContent>(ContentNameManager.More);
            
        }
    }
}
