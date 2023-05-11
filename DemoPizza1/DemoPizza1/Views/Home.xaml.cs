using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoPizza1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();

            fechaLabel.Text = DateTime.Now.ToString("dd/MM/yyyy");

            T_NomUsuario.Text = (string)Application.Current.Properties["T_Nombre"];
        }

        private void btn_Comprar_Pedido(object sender, EventArgs e)
        {

        }
    }
}