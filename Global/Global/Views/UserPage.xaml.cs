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
	public partial class UserPage : ContentPage
	{
        private const string Url = "http://192.168.0.62:8082/api/Lgpersons";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<Lgperson> _lgperson;

        public UserPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            string content = await client.GetStringAsync(Url);
            List<Lgperson> lgperson = JsonConvert.DeserializeObject<List<Lgperson>>(content);
            _lgperson = new ObservableCollection<Lgperson>(lgperson);
            MyListView.ItemsSource = _lgperson;
            base.OnAppearing();
        }
    }
}