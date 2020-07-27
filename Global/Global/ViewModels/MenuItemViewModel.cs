using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using Global.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Global.ViewModels
{
    public class MenuItemViewModel
    {
        #region Attributes
        private NavigationService navigationService; 
        #endregion

        #region Properties
        public string icon { get; set; }
        public string Title { get; set; }
        public string PageName { get; set; }
        #endregion

        #region Constructor
        public MenuItemViewModel()
        {
            navigationService = new NavigationService();
        } 
        #endregion

        #region Commands
        public ICommand NavigateCommand { get { return new RelayCommand(Navigate); } }

        private async void Navigate()
        {
           await navigationService.Navigate(PageName);
        } 
        #endregion
    }
}
