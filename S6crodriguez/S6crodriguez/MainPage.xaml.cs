using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace S6crodriguez
{
    public partial class MainPage : ContentPage
    {
        private string URL = "http://192.168.10.45/ws_uisrael/post.php";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<estudiante> post;



        public MainPage()
        {
            InitializeComponent();
            Obtener();
        }

        public async void Obtener()
        {
            var contenido = await client.GetStringAsync(URL);
            List<estudiante> datosPost = JsonConvert.DeserializeObject<List<estudiante>>(contenido);
            post = new ObservableCollection<estudiante>(datosPost);
            listaEstudiantes.ItemsSource = post;
        }
        private async void btnConsultar_Clicked(object sender, EventArgs e)
        {
           

        }
    }
}
