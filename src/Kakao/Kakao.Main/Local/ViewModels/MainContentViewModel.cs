using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using Kakao.Core.Models;
using Kakao.Core.Names;
using Prism.Ioc;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kakao.Main.Local.ViewModels
{
    public partial class MainContentViewModel : ObservableBase
    {
        private readonly IRegionManager _regionManager;
        private readonly IContainerProvider _containerProvider;

        // get,set 프로퍼티 만들지 않아도 필드만 만들어도 됨
        [ObservableProperty]
        private List<MenuModel> _menus;
        [ObservableProperty]
        private MenuModel _menu;


        public MainContentViewModel(IRegionManager regionManager, IContainerProvider containerProvider)
        {
            _regionManager = regionManager;
            _containerProvider = containerProvider;
            Menus = GetMenus();

        }

        private List<MenuModel> GetMenus()
        {
            List<MenuModel> source  = new ();
            source.Add(new MenuModel().DataGetn(ContentNameManager.Chats));
            source.Add(new MenuModel().DataGetn(ContentNameManager.Friends));
            source.Add(new MenuModel().DataGetn(ContentNameManager.More));

            return source;
        }
        partial void OnMenuChanged(MenuModel value)
        {
            IRegion contentRegion = _regionManager.Regions[RegionNameManager.ContentRegion];
            IViewable content = _containerProvider.Resolve<IViewable>(value.Id);

            if (!contentRegion.Views.Contains(content))
            {
                contentRegion.Add(content);
            }
            contentRegion.Activate(content);
        }

        // 필요 없어짐
        //[RelayCommand]
        //private void Chats()
        //{
        //    IRegion contentRegion = _regionManager.Regions[RegionNameManager.ContentRegion];
        //    IViewable ChatsContent = _containerProvider.Resolve<IViewable>(ContentNameManager.Chats);

        //    if (!contentRegion.Views.Contains(ChatsContent))
        //    {
        //        contentRegion.Add(ChatsContent);
        //    }
        //    contentRegion.Activate(ChatsContent);
        //}
        //[RelayCommand]
        //private void Friends()
        //{
        //    IRegion contentRegion = _regionManager.Regions[RegionNameManager.ContentRegion];
        //    IViewable friendsContent = _containerProvider.Resolve<IViewable>(ContentNameManager.Friends);

        //    if (!contentRegion.Views.Contains(friendsContent))
        //    {
        //        contentRegion.Add(friendsContent);
        //    }
        //    contentRegion.Activate(friendsContent);
        //}
        [RelayCommand]
        private void Logout()
        {
            IRegion mainRegion = _regionManager.Regions[RegionNameManager.MainRegion];
            IViewable loginContent = _containerProvider.Resolve<IViewable>(ContentNameManager.Login);

            if (!mainRegion.Views.Contains(loginContent))
            {
                mainRegion.Add(loginContent);
            }
            mainRegion.Activate(loginContent);
        }
    }
}
