using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PM2P1EJ2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Btnpagemain_Clicked(object sender, EventArgs e)
        {
            var Contactos = new Models.Contactos()
            {
                Nombre = this.txtnombre.Text,
                Apellido = this.txtapellido.Text,
                Edad = Convert.ToInt32(this.txtedad.Text),
                CorreoElectronico = this.txtcorreo.Text
            };

            var pagina = new PageMain();
            pagina.BindingContext = Contactos;
            await Navigation.PushAsync(pagina);
        }
    }
}
