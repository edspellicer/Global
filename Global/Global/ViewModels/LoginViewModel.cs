using GalaSoft.MvvmLight.Command;
using Global.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Global.ViewModels
{
    public class LoginViewModel
    {
        #region Attributes

        private NavigationService navigationService;

        private DialogService dialogService;
        #endregion

        #region Properties
        public string CodPer { get; set; }

        #endregion

        #region Constructor
        public LoginViewModel()
        {
            navigationService = new NavigationService();
            dialogService = new DialogService();
        } 
        #endregion

        #region Commands
        public ICommand LoginCommand { get { return new RelayCommand(Login); } }
        private async void Login()
        {
            if (string.IsNullOrEmpty(CodPer))
            {
                await dialogService.ShowMessage("Error", "Debes Ingresar Código de Usuario");
                return;
            }
            navigationService.SetMainPage();
        } 
        #endregion
    }
 }
