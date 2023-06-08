using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using Kakao.Core.Names;
using Prism.Ioc;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kakao.Login.Local.ViewModels
{
    public partial class LoginContentViewModel: ObservableBase
    {
        private readonly IRegionManager _regionManager;
        private readonly IContainerProvider _containerProvider;
        public LoginContentViewModel(IRegionManager regioManager, IContainerProvider containerProvider) 
        {
            _regionManager = regioManager;
            _containerProvider = containerProvider;
        }

        [RelayCommand]
        private void Login()
        {
            IRegion mainRegion = _regionManager.Regions[RegionNameManager.MainRegion];
            IViewable friendsContent = _containerProvider.Resolve<IViewable>(ContentNameManager.Friends);

            if (!mainRegion.Views.Contains(friendsContent))
            {
                mainRegion.Add(friendsContent);
            }
            mainRegion.Activate(friendsContent);
        }
    }
}
