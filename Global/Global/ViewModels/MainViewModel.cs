using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Global.ViewModels
{
    public class MainViewModel
    {
 #region Properties 
        public ObservableCollection<MenuItemViewModel> Menu { get; set; }
        public LoginViewModel NewLogin { get; set; }

        #endregion

 #region Constructors
        public MainViewModel()
        {
            Menu = new ObservableCollection<MenuItemViewModel>();
            NewLogin = new LoginViewModel();
            LoadMenu();
        }
        #endregion

#region Methods
        private void LoadMenu() // Creacion de item de Menu Principal
        {
            Menu.Add(new MenuItemViewModel{
                icon = "asigna.png",
                Title="Asignaciones",
                PageName="AsignaPage"
            });

            Menu.Add(new MenuItemViewModel
            {
                icon = "box.png",
                Title = "Picking",
                PageName = "PickingPage"
            });

            Menu.Add(new MenuItemViewModel
            {
                icon = "revision.png",
                Title = "Revisiones",
                PageName = "RevPage"
            });
            Menu.Add(new MenuItemViewModel
            {
                icon = "users.png",
                Title = "Usuarios",
                PageName = "UserPage"
            });
            Menu.Add(new MenuItemViewModel
            {
                icon = "exit.png",
                Title = "Salir",
                PageName = "SalirPage"
            });
        }
        #endregion

    }
}
