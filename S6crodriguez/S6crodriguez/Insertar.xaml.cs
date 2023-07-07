using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace S6crodriguez
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Insertar : ContentPage
    {
        private string URL = "http://192.168.10.45/ws_uisrael/post.php";
        public Insertar()
        {
            InitializeComponent();
        }
        private void btnIngresar_Clicked(object sender, EventArgs e)
        {
            try
            {
                WebClient cliente = new WebClient();
                var datos = new System.Collections.Specialized.NameValueCollection();
                datos.Add("codigo", txtcodigo.Text);
                datos.Add("nombre", txtnombre.Text);
                datos.Add("apellido", txtapellido.Text);
                datos.Add("edad", txtedad.Text);

                cliente.UploadValues(URL, "POST", datos);

                var mensaje = "Dato ingresado con exito";
                DependencyService.Get<mensaje>().longAlert(mensaje);

                Navigation.PushAsync(new MainPage());
            }
            catch (Exception ex)
            {

                DisplayAlert("Alerta", ex.Message, "Cerrar");
            }
        }
    }
}