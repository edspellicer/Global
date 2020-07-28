using Global.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Global.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PickingPage : ContentPage
	{
        private const string Url = "http://192.168.0.62:8082/api/PedidosAsignados";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<PedidosAsignados> _pedidoasignado;
        public PickingPage ()
		{
			//InitializeComponent ();
		}
        protected override async void OnAppearing()
        {
            string content = await client.GetStringAsync(Url);
            List<Lgperson> lgperson = JsonConvert.DeserializeObject<List<Lgperson>>(content);
            //_pedidoasignado = new ObservableCollection<PedidosAsignados>(pedidoasignado);
            //MyListViewpa.ItemsSource = _pedidoasignado;
            base.OnAppearing();
        }
    }
}