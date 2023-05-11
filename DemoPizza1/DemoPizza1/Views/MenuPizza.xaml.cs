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
    public partial class MenuPizza : ContentPage
    {
        public MenuPizza()
        {
            InitializeComponent();
        }
        int pizza = 0;
        private void btn_pizza(object sender, EventArgs e)
        {
            pizza = pizza + 1;

            //pizzas_compra.Text = "Carrito : " + pizza + " Pizzas";
        }
    }
}