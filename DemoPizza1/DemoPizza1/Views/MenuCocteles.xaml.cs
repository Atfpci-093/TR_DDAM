using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Essentials;
using Xamarin.Forms.Xaml;

namespace DemoPizza1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuCocteles : ContentPage
    {
        public MenuCocteles()
        {
            InitializeComponent();
            
            //var htmlcontent = new HtmlWebViewSource();
            //htmlcontent.Html = "<html><head></head><body>" +
            //"<iframe width='560' height='315' src='https://www.youtube.com/embed/qkw1fEf53-Q' " +
            //"title='YouTube video player' frameborder='0' allow='accelerometer; autoplay; clipboard-write; " +
            //"encrypted-media; gyroscope; picture-in-picture; web-share' allowfullscreen></iframe>" +
            //"</body></html>";
            //Video.Source = htmlcontent;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Launcher.OpenAsync("https://www.facebook.com/");
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            Launcher.OpenAsync("https://twitter.com/");
        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            Launcher.OpenAsync("https://www.instagram.com/");
        }
    }
}