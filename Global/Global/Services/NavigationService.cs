using Global.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Global.Services
{
    public class NavigationService
    {
        public async Task Navigate(string PageName)
        {
            App.Master.IsPresented = false;
            switch (PageName)
            {
                case "AsignaPage":
                 await App.Navigator.PushAsync(new AsignaPage());
                    break;
                case "PickingPage":
                    await App.Navigator.PushAsync(new PickingPage());
                    break;
                case "RevPage":
                    await App.Navigator.PushAsync(new RevPage());
                    break;
                case "UserPage":
                    await App.Navigator.PushAsync(new UserPage());
                    break;
                
                default:
                    break;
            }
        }
    }
}
