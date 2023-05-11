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
    public partial class MenuBebidas : ContentPage
    {
        public MenuBebidas()
        {
            InitializeComponent();
        }

        int bebidas = 0;
        private void btn_bebidas(object sender, EventArgs e)
        {
            bebidas = bebidas + 1;

        }
    }
}