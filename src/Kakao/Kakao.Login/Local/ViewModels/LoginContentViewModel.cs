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
    public partial class LoginContentViewModel: ObservableBase, INavigationAware
    {
        private readonly IRegionManager _regionManager;
        private readonly IContainerProvider _containerProvider;
        public LoginContentViewModel(IRegionManager regioManager, IContainerProvider containerProvider) 
        {
            _regionManager = regioManager;
            _containerProvider = containerProvider;
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
        }

        [RelayCommand]
        private void Login()
        {
            IRegion mainRegion = _regionManager.Regions[RegionNameManager.MainRegion];
            IViewable mainContent = _containerProvider.Resolve<IViewable>(ContentNameManager.Main);

            if (!mainRegion.Views.Contains(mainContent))
            {
                mainRegion.Add(mainContent);
            }
            mainRegion.Activate(mainContent);
        }
    }
}
