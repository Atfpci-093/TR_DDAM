using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoPizza1.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DemoPizza1.Data;
using DemoPizza1.Registro;

namespace DemoPizza1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }
        //ConsultarUsuaruioByIdsi

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            var T_Correo = T_NombreUsu.Text;
            var T_Contraseña = T_Password.Text;
         
            if (ValidarCampos() == true)
            {
                var Usuario = await App.SQLiteDB.ConsultarUsuaruioById(T_Correo, T_Contraseña);

                if (Usuario != null)
                {
                    await DisplayAlert("Ingreso", "Usted se a logeado correctamente", "OK");
                    await Navigation.PushAsync(new MainPage());
                }
                else
                {
                    await DisplayAlert("Incorrecto", "Correo o Contraseña Incorrectos", "OK");
                }
            }
            else
            {
                await DisplayAlert("Advertencia", "Uno de los campos esta vacio", "OK");
            }
        }   

        public bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(T_NombreUsu.Text))
            {
                return false;
            } 
            else if (string.IsNullOrEmpty(T_Password.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DemoPizza1.Views.Page1());
        }

        private void T_NombreUsu_TextChanged(object sender, TextChangedEventArgs e)
        {
            Application.Current.Properties["T_Nombre"] = e.NewTextValue;
        }

        private void T_Password_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
    }
}